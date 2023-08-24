using Dynamitey.DynamicObjects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Helpers
{
    public class RequestParams

    {
        public string baseUrl;

        public string restRequestPath;

        public Method method;

        public RequestParams(string baseUrl, string restRequestPath, Method method)
        {
            this.baseUrl = baseUrl;
            this.restRequestPath = restRequestPath;
            this.method = method;
        }
    }
}
