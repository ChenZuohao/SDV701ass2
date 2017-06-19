using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SDVASS2Selfhost
{
    public class GalleryController: System.Web.Http.ApiController
    {
        public List<string> GetBrandName()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT Car_BrandName FROM CarBrand", null);
            List<string> lcName = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcName.Add((string)dr[0]);
            return lcName;
        }

        public clsCarBrand GetBrand(string Car_BrandName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Car_BrandName", Car_BrandName);
            DataTable lcResult =
        clsDbConnection.GetDataTable("SELECT * FROM CarBrand WHERE Car_BrandName = @Car_BrandName", par);
            if (lcResult.Rows.Count > 0)
                return new clsCarBrand()
                {

                    Car_BrandName = (string)lcResult.Rows[0]["Car_BrandName"],
                    BrandCountry = (string)lcResult.Rows[0]["BrandCountry"],
                    WorksList = getBrandWork(Car_BrandName)
                };
            else
                return null;
        }

        public string DeleteCar(clsCar prWork)
        {   // Delete
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "DELETE FROM Car WHERE Car_BrandName = @Car_BrandName AND Car_ID = @Car_ID",
        prepareCarParameters(prWork));
                if (lcRecCount == 1)
                    return "One Car Delete";
                else
                    return "Unexpected artist Delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private List<clsCar> getBrandWork(string car_BrandName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("car_BrandName", car_BrandName);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM Car WHERE car_BrandName = @car_BrandName", par);
            List<clsCar> lccar = new List<clsCar>();
            foreach (DataRow dr in lcResult.Rows)
                lccar.Add(dataRow2Car(dr));
            return lccar;

        }

        public string RemoveBrand(string brandName)
        {   // Add
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>();
                par.Add("Car_BrandName", brandName);
                int lcRecCount = clsDbConnection.Execute(
        "DELETE FROM dbo.CarBrand WHERE Car_BrandName=@Car_BrandName", par);
                if (lcRecCount == 1)
                    return "One artist removed";
                else
                    return "Unexpected artist removed count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        private clsCar dataRow2Car(DataRow prDataRow)
        {
            return new clsCar()
            {
                Car_ID = int.Parse(prDataRow["Car_ID"].ToString()),
                Car_ModleName = (prDataRow["Car_ModleName"].ToString()),
                Car_BrandName = (prDataRow["Car_BrandName"].ToString()),
                Car_Type = (prDataRow["Car_Type"].ToString()),
                Car_Price = Convert.ToDecimal(prDataRow["Car_Price"].ToString()),
                Date_LastModified = Convert.ToDateTime(prDataRow["Date_LastModified"]),
                Date_Manufacture = int.Parse(prDataRow["Date_Manufacture"].ToString()),
                Availabe = int.Parse(prDataRow["Availabe"].ToString()),
                Type = (prDataRow["Type"].ToString())


                //Name = Convert.ToString(prDataRow["Name"]),
                //Date = Convert.ToDateTime(prDataRow["Date"]),
                //Value = Convert.ToDecimal(prDataRow["Value"]),
                //Width = prDataRow["Width"] is DBNull ? (float?)null : Convert.ToSingle(prDataRow["Width"]),
                //Height = prDataRow["Height"] is DBNull ? (float?)null : Convert.ToSingle(prDataRow["Height"]),
                //Type = Convert.ToString(prDataRow["Type"]),
                //Weight = prDataRow["Weight"] is DBNull ? (float?)null : Convert.ToSingle(prDataRow["Weight"]),
                //Material = Convert.ToString(prDataRow["Material"]),
                //ArtistName = Convert.ToString(prDataRow["ArtistName"]),
                //WorkType = Convert.ToChar(prDataRow["WorkType"])
                // Your turn:
            };
        }

        public string upBrand(clsCarBrand prBrand)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "UPDATE CarBrand SET BrandCountry = @BrandCountry, Car_BrandName = @Car_BrandName",
        prepareBrandParameters(prBrand));
                if (lcRecCount == 1)
                    return "One Brand updated";
                else
                    return "Unexpected artist update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string upCar(clsCar prCar)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "UPDATE Car SET Car_ModleName =@Car_ModleName,Car_Type =@Car_Type,Car_Price=@Car_Price,Date_Manufacture=@Date_Manufacture,Date_LastModified = @Date_LastModified,Availave =@Availave,Type =@Type WHERE Car_BrandName = @Car_BrandName AND Car_ID = @Car_ID",
        prepareCarParameters(prCar));
                if (lcRecCount == 1)
                    return "One Car updated";
                else
                    return "Unexpected Car update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string AddBrand(clsCarBrand prBrand)
        {   // Add
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "INSERT INTO CarBrand VALUES(@Car_BrandName,@BrandCountry)",
        prepareBrandParameters(prBrand));
                if (lcRecCount == 1)
                    return "One Brand added";
                else
                    return "Unexpected artist added count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareBrandParameters(clsCarBrand prBrand)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(3);
            par.Add("Car_BrandName", prBrand.Car_BrandName);
            par.Add("BrandCountry", prBrand.BrandCountry);
            return par;
        }

        public string AddCar(clsCar prCar)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute(@"INSERT INTO [dbo].[Car]
           ([Car_ID]
           ,[Car_ModleName]
           ,[Car_BrandName]
           ,[Car_Type]
           ,[Car_Price]
           ,[Date_Manufacture]
           ,[Date_LastModified]
           ,[Availabe]
           ,[Type])
     VALUES
           (@Car_ID,@Car_ModleName,@Car_BrandName,@Car_Type,@Car_Price,@Date_Manufacture,@Date_LastModified,@Availabe,@Type)",
                prepareCarParameters(prCar));

                if (lcRecCount == 1)
                    return "One Car inserted";
                else
                    return "Unexpected Car insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareCarParameters(clsCar prWork)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("Car_ID", prWork.Car_ID);
            par.Add("Car_ModleName", prWork.Car_ModleName);
            par.Add("Car_BrandName", prWork.Car_BrandName);
            par.Add("Car_Type", prWork.Car_Type);
            par.Add("Car_Price", prWork.Car_Price);
            par.Add("Date_Manufacture", prWork.Date_Manufacture);
            par.Add("Date_LastModified", prWork.Date_Manufacture);
            par.Add("Availabe", prWork.Availabe);
            par.Add("Type", prWork.Type);
            // Etc: your turn:

            return par;
        }
        public List<ClsCarOrder> GetCarOrderList()
        {
            List<ClsCarOrder> _ClsCarOrderList = new List<ClsCarOrder>();
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM CarOrder", null);

            foreach (DataRow dr in lcResult.Rows)
            {
                ClsCarOrder _ClsCarOrder = new ClsCarOrder();
                _ClsCarOrder.Car_ID = int.Parse(dr[0].ToString());
                _ClsCarOrder.Customer_Name = dr[1].ToString();
                _ClsCarOrder.Customer_Phone = dr[2].ToString();
                _ClsCarOrder.Customer_Email = dr[3].ToString();
                _ClsCarOrder.OrderDate = DateTime.Parse(dr[4].ToString());

                _ClsCarOrder.Price = decimal.Parse(dr[5].ToString());
                _ClsCarOrder.Type = dr[6].ToString();
                _ClsCarOrderList.Add(_ClsCarOrder);
            }
            return _ClsCarOrderList;
        }

        [HttpDelete]
        public string RemoveCarOrder(int Car_ID)
        {
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>();
                par.Add("Car_ID", Car_ID);
                int lcRecCount = clsDbConnection.Execute("DELETE FROM dbo.CarOrder WHERE Car_ID=@Car_ID", par);
                if (lcRecCount == 1)
                    return "One artist removed";
                else
                    return "Unexpected artist removed count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        [HttpDelete]
        public string RemoveCarBrand(string Car_BrandName)
        {   // Add
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>();
                par.Add("Car_BrandName", Car_BrandName);
                int lcRecCount = clsDbConnection.Execute("DELETE FROM dbo.CarBrand WHERE Car_BrandName=@Car_BrandName", par);
                if (lcRecCount == 1)
                    return "One artist removed";
                else
                    return "Unexpected artist removed count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        [HttpDelete]
        public string RemoveCar(int Car_ID)
        {   // Add
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>();
                par.Add("Car_ID", Car_ID);
                int lcRecCount = clsDbConnection.Execute("DELETE FROM dbo.Car WHERE Car_ID=@Car_ID", par);
                if (lcRecCount == 1)
                    return "One artist removed";
                else
                    return "Unexpected artist removed count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }





    }

}
