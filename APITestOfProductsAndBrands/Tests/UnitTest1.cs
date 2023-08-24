using ApiTest.JsonTemplates;
using System;
using SpecFlow.Internal.Json;
using ApiTest.JsonAPI;
using ApiTest.Helpers;
using RestSharp;

namespace ApiTest.Tests
{
    public class Tests
    {


        [Test]
        public void TestApiOfProducts()

        {
            var parameters = new RequestParams("https://automationexercise.com", "/api/productsList", Method.Get);

            var response = ApiCallMethodTemplate.GetJsonTemplates<ListOfProducts>(parameters);

            var statusCode = response.ResponseCode;

            Assert.That(statusCode, Is.EqualTo(200));
            Assert.That(response.Products[11].Category.category, Is.EqualTo("Tops & Shirts"));

            /*
            Console.WriteLine(response.ToJson());
            Console.WriteLine(response.ResponseCode);
            Console.WriteLine(response.Products[0].Id);
            Console.WriteLine(response.Products[0].Name);
            Console.WriteLine(response.Products[0].Price);
            Console.WriteLine(response.Products[0].Brand);
            Console.WriteLine(response.Products[0].Category.Usertype.Usertype);
            Console.WriteLine(response.Products[11].Category.category); 
            */
        }


        [Test]
        public void TestApiOfBrands()
        {
            var parameters = new RequestParams("https://automationexercise.com", "/api/brandsList", Method.Get);

            var response = ApiCallMethodTemplate.GetJsonTemplates<ListOfBrands>(parameters);

            Assert.That(response.ResponseCode, Is.EqualTo(200));
            Assert.That(response.Brands[0].Id, Is.EqualTo(1));
            Assert.That(response.Brands[0].brand, Is.EqualTo("Polo"));

            /*
            Console.WriteLine(response.ToJson());
            Console.WriteLine(response.ResponseCode);
            Console.WriteLine(response.Brands[0].Id);
            Console.WriteLine(response.Brands[0].brand);
            */

        }
    }
}
