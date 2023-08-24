using ApiTest.JsonAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.JsonTemplates
{
    public class ListOfBrands
    {

        public long ResponseCode { get; set; }
        public List<Brand> Brands { get; set; }
    }

    public partial class Brand
    {
        public long Id { get; set; }
        public string brand { get; set; }
    }
}



