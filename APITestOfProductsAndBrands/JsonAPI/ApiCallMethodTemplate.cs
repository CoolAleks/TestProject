using Newtonsoft.Json;
using RestSharp;
using ApiTest.Helpers;

namespace ApiTest.JsonAPI
{
    public class ApiCallMethodTemplate
    {
        public static T GetJsonTemplates<T>(RequestParams parameters)

        {
            var restClient = new RestClient(parameters.baseUrl);
            var restRequest = new RestRequest(parameters.restRequestPath, parameters.method);
            //restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var products = JsonConvert.DeserializeObject<T>(content);
            return products;
        }
    }
}
