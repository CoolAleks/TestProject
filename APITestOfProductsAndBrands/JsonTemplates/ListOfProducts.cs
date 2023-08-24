using ApiTest.JsonAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.JsonTemplates
{

    public class ListOfProducts

    {
        public long ResponseCode { get; set; }
        public List<Product> Products { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }


    public partial class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }
        public Category Category { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

    public partial class Category
    {
        public UsertypeClass Usertype { get; set; }
        public string category { get; set; }


        public override string? ToString()
        {
            return base.ToString();
        }
    }

    public partial class UsertypeClass
    {
        public UsertypeEnum Usertype { get; set; }

    }

    public enum UsertypeEnum { Kids, Men, Women };
}
