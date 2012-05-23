using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Eleven41.PayPal
{
	public class PayPalInvoiceClient
	{
		public PayPalInvoiceClient(string username, string password, string signature, string appId)
		{
			IsTest = false;
			Username = username;
			Password = password;
			Signature = signature;
			AppId = appId;
		}

		public PayPalInvoiceClient(string username, string password, string signature, string appId, bool isTest = false)
			: this(username, password, signature, appId)
		{
			IsTest = isTest;
		}

		public bool IsTest { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Signature { get; set; }
		public string AppId { get; set; }

		public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest request)
		{
			request.RequestEnvelope = FixRequestEnvelope(request.RequestEnvelope);

			var response = Invoke<CreateInvoiceRequest, CreateInvoiceResponseEx>("CreateInvoice", request);
			if (response.Error != null &&
				response.Error.Count > 0)
			{
				throw new Exception(response.Error[0].Message);
			}
			return response;
		}

		public CreateAndSendInvoiceResponse CreateAndSendInvoice(CreateAndSendInvoiceRequest request)
		{
			request.RequestEnvelope = FixRequestEnvelope(request.RequestEnvelope);
			
			var response = Invoke<CreateAndSendInvoiceRequest, CreateAndSendInvoiceResponseEx>("CreateAndSendInvoice", request);
			if (response.Error != null &&
				response.Error.Count > 0)
			{
				throw new Exception(response.Error[0].Message);
			}
			return response;
		}

		public SendInvoiceResponse SendInvoice(SendInvoiceRequest request)
		{
			request.RequestEnvelope = FixRequestEnvelope(request.RequestEnvelope);

			var response = Invoke<SendInvoiceRequest, SendInvoiceResponseEx>("SendInvoice", request);
			if (response.Error != null &&
				response.Error.Count > 0)
			{
				throw new Exception(response.Error[0].Message);
			}
			return response;
		}

		public GetInvoiceDetailsResponse GetInvoiceDetails(GetInvoiceDetailsRequest request)
		{
			request.RequestEnvelope = FixRequestEnvelope(request.RequestEnvelope);

			var response = Invoke<GetInvoiceDetailsRequest, GetInvoiceDetailsResponseEx>("GetInvoiceDetails", request);
			if (response.Error != null &&
				response.Error.Count > 0)
			{
				throw new Exception(response.Error[0].Message);
			}
			return response;
		}

		private RequestEnvelope FixRequestEnvelope(RequestEnvelope requestEnvelope)
		{
			if (requestEnvelope == null)
				requestEnvelope = new RequestEnvelope();
			if (String.IsNullOrEmpty(requestEnvelope.ErrorLanguage))
				requestEnvelope.ErrorLanguage = "en_US";
			return requestEnvelope;
		}

		const string EndpointBase = "https://svcs.paypal.com/Invoice/";
		const string EndpointTestBase = "https://svcs.sandbox.paypal.com/Invoice/";

		private string GetEndpoint()
		{
			if (IsTest)
				return EndpointTestBase;
			else
				return EndpointBase;
		}

		private HttpWebRequest ConfigureWebRequest(string command)
		{
			var url = GetEndpoint() + command;
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

			request.Method = "POST";

			request.Headers.Add("X-PAYPAL-SECURITY-USERID", Username);
			request.Headers.Add("X-PAYPAL-SECURITY-PASSWORD", Password);
			request.Headers.Add("X-PAYPAL-SECURITY-SIGNATURE", Signature);
			request.Headers.Add("X-PAYPAL-APPLICATION-ID", AppId);
			request.Headers.Add("X-PAYPAL-REQUEST-DATA-FORMAT", "JSON");
			request.Headers.Add("X-PAYPAL-RESPONSE-DATA-FORMAT", "JSON");

			return request;
		}

		private T Invoke<U, T>(string command, U requestObj)
		{
			string requestBody = ServiceStack.Text.JsonSerializer.SerializeToString<U>(requestObj);
			T response = default(T);
			HttpStatusCode statusCode = default(HttpStatusCode);
			byte[] requestData = System.Text.Encoding.UTF8.GetBytes(requestBody);

			string responseBody = null;
			var request = ConfigureWebRequest(command);

			//try
			{
				using (Stream requestStream = request.GetRequestStream())
				{
					requestStream.Write(requestData, 0, requestData.Length);
				}
				using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
				{
					if (httpResponse == null)
					{
						throw new WebException(
							"The Web Response for a successful request is null!",
							WebExceptionStatus.ProtocolError
							);
					}
					statusCode = httpResponse.StatusCode;
					using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
					{
						responseBody = reader.ReadToEnd();
					}
				}

				response = ServiceStack.Text.JsonSerializer.DeserializeFromString<T>(responseBody);
			}
			//catch (WebException e)
			{
			}

			return response;
		}

		private Dictionary<string, string> ConvertNV(string keyValues)
		{
			Dictionary<string, string> results = new Dictionary<string, string>();
			var lines = keyValues.Split('&');

			foreach (var line in lines)
			{
				var keyValue = line.Split('=');
				string key = keyValue[0];
				string value = keyValue[1];

				results.Add(key, value);
			}

			return results;
		}
	}
}
