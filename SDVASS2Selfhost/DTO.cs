using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVASS2Selfhost
{
    public class clsCarBrand
    {
        public string Car_BrandName { get; set; }
        public string BrandCountry { get; set; }
        public List<clsCar> WorksList { get; set; }
    }
    public class ClsCarOrder
    {
        public int Car_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Email { get; set; }
        public DateTime OrderDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
    public class clsCar
    {
        public int Car_ID { get; set; }
        public string Car_ModleName { get; set; }
        public string Car_BrandName { get; set; }
        public string Car_Type { get; set; }
        public decimal Car_Price { get; set; }
        public int Date_Manufacture { get; set; }
        public DateTime Date_LastModified { get; set; }
        public int Availabe { get; set; }
        public string Type { get; set; }

        public string _DisplayMember { get { return Car_ModleName + "\t" + Type.ToUpper(); } }

    }
}
