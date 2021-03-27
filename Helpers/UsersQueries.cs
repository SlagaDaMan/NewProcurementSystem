using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using ProcurementSystem.Models;

namespace ProcurementSystem.Helpers
{
    public class UsersQueries
    {
        public DataTable ExecuteQueryFunction(string Query)
        {
            string connectionString = "Data Source=ACEENDS\\SQLEXPRESS;Initial Catalog=ProcurementSystem;Integrated Security=True";
            // string dd = Properties.Settings.Default.OfficeManagementSystemConnectionString.ToString();

            // string connectionString = "Data Source=SQL6010.site4now.net;Initial Catalog=DB_A62B58_eazybill;User Id=DB_A62B58_eazybill_admin;Password=Password@1;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                connection.Open();
                var dataReader = command.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(dataReader);

                return dataTable;
            }
        }

        public DataTable GetUserDetailByID(string ID)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Select * from User Where ID = " + ID );
            return dt;

        }
        public DataTable GetAllUserDetailBy()
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Select * from User");
            return dt;


        }
            public DataTable UpdateUserDetails(string ID, string PersalNumber, string BranchID, string UserTypeID, string FirstName, string LastName, string Email, string Password, string ContactNumber,string UpdatedBy,string UpdatedDate)
            {
                DataTable dt = new DataTable();
                dt = ExecuteQueryFunction("Update User set PersalNumber = " + PersalNumber +
                    ", BranchID = " + BranchID +
                    ", UserTypeID = " + UserTypeID +
                    ", FirstName = " + FirstName +
                    ", LastName = " + LastName +
                    ", Email = " + Email +
                    ", ContactNumber = " + ContactNumber +
                    ", UpdatedBy = " + UpdatedBy +
                    ", UpdatedBy = " + UpdatedBy + "Where ID = " + ID);
                return dt;

            }

        public DataTable SetUserDetails(string ID, string PersalNumber, string BranchID, string UserTypeID, string FirstName, string LastName, string Email, string Password, string ContactNumber, string UpdatedBy, string UpdatedDate)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Insert into User(PersalNumber,BranchID,UserTypeID,FirstName,LastName,Email,Password,ContactNumber,UpdatedBy,UpdatedDate) Values "
                                      + $"({PersalNumber},{BranchID},{UserTypeID},'{FirstName}','{LastName}','{Email}','{Password}','{ContactNumber}','{UpdatedBy}','{UpdatedDate}')");
            return dt;
        }

        public int GetBranchID(string Branch)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select ID from Branch Where Description ='{Branch}'");
            int BranchID = Convert.ToInt16(dt.Rows[0][0].ToString());
            return BranchID;
        }

        public string GetBranchCodeByDesc(string Branch)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select Code from Branch Where Description ='{Branch}'");
            string BranchCode = dt.Rows[0][0].ToString();
            return BranchCode;
        }

        public string GetBranchDescByID(string ID)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select Description from Branch Where ID ={ID}");
            string BranchDescription = dt.Rows[0][0].ToString();
            return BranchDescription;
        }

        public int GetApplicationTypeID(string Description)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select ID from ApplicationType Where Description ={Description}");
            int TypeID = Convert.ToInt16(dt.Rows[0][0].ToString());

            return TypeID;
        }

        public string GetApplicationTypeDescByID(string ID)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select Description from ApplicationType Where ID ={ID}");
            string BranchDescription = dt.Rows[0][0].ToString();
            return BranchDescription;
        }

        public int GetApplicationSubTypeID(string Description)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select ID from ApplicationSubType Where Description ={Description}");
            int TypeID = Convert.ToInt16(dt.Rows[0][0].ToString());

            return TypeID;
        }

        public string GetApplicationSubTypeDescByID(string ID)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select Description from ApplicationSubType Where ID ={ID}");
            string BranchDescription = dt.Rows[0][0].ToString();
            return BranchDescription;
        }

        public string GetStatusByID(string ID)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select Description from Status Where ID ={ID}");
            string Status = dt.Rows[0][0].ToString();
            return Status;
        }

        public int GetStatusIDByDesc(string Description)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction($"Select ID from Status Where Description ={Description}");
            int StatusID = Convert.ToInt16(dt.Rows[0][0].ToString());

            return StatusID;
        }

        public DataTable SetPSA_ApplicationDetails(string TypeID, string SubTypeID, string AppDate, string FirstName, string LastName, string PersalNo, string ComponentDetails, string ContactNumber, string AppEmail, string BOSR, string LossRef, string RefDate, string AssetNumber, string SerialNumber, string Description, string Unit, string ResponsibleNumber, string PremisesName, string CovertOvert, string PremisesSRNumber, string Equipment, string EquipmentDesc, string NumberOfItems, string CreatedBy, string CreatedDate, string UpdatedBy, string UpdatedDate)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Insert into PSA_ApplicationDetails(TypeID,SubTypeID,AppDate,FirstName,LastName,PersalNo,ComponentDetails,ContactNumber,AppEmail,BOSR,LossRef,RefDate,AssetNumber,SerialNumber,Description,Unit,ResponsibleNumber,PremisesName,CovertOvert,PremisesSRNumber,Equipment,EquipmentDesc,NumberOfItems,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) Values "
                                      + $"({TypeID},{SubTypeID},'{AppDate}','{FirstName}','{LastName}','{PersalNo}','{ComponentDetails}','{ContactNumber}','{AppEmail}','{BOSR}','{LossRef}','{RefDate}','{AssetNumber}','{SerialNumber}','{Description}','{Unit}','{ResponsibleNumber}','{PremisesName}','{CovertOvert}','{PremisesSRNumber}','{Equipment}','{EquipmentDesc}','{NumberOfItems}','{CreatedBy}','{CreatedDate}','{UpdatedBy}','{UpdatedDate}')");
            return dt;  
        }

        public DataTable UpdatePSA_ApplicationDetails(string ID,string TypeID, string SubTypeID, string AppDate, string FirstName, string LastName, string PersalNo, string ComponentDetails, string ContactNumber, string AppEmail, string BOSR, string LossRef, string RefDate, string AssetNumber, string SerialNumber, string Description, string Unit, string ResponsibleNumber, string PremisesName, string CovertOvert, string PremisesSRNumber, string Equipment, string EquipmentDesc, string NumberOfItems, string CreatedBy, string CreatedDate, string UpdatedBy, string UpdatedDate)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Update User set TypeID = " + TypeID +
                ", SubTypeID = " + SubTypeID +
                ", AppDate = '" + AppDate +
                "', FirstName = '" + FirstName +
                "', LastName = '" + LastName +
                "', PersalNo = " + PersalNo +
                ", ComponentDetails = '" + ComponentDetails +
                "', ContactNumber = '" + ContactNumber +
                "', AppEmail = '" + AppEmail +
                "', BOSR = '" + BOSR +
                "', LossRef = '" + LossRef +
                "', RefDate = '" + RefDate +
                "', AssetNumber = '" + AssetNumber +
                "', SerialNumber = '" + SerialNumber +
                "', Description = '" + Description +
                "', ContactNumber = '" + Unit +
                "', ResponsibleNumber = '" + ResponsibleNumber +
                "', PremisesName = '" + PremisesName +
                "', CovertOvert = '" + CovertOvert +
                "', PremisesSRNumber = '" + PremisesSRNumber +
                "', Equipment = '" + Equipment +
                "', EquipmentDesc = '" + EquipmentDesc +
                "', NumberOfItems = '" + NumberOfItems +
                "', CreatedBy = '" + CreatedBy +
                "', CreatedDate = '" + CreatedDate +
                "', UpdatedBy = '" + UpdatedBy +
                "', UpdatedDate = '" + UpdatedDate +
                "', AppEmail = '" + AppEmail + "Where ID = " + ID);
            return dt;
        }

        public DataTable SetPSV_ApplicationDetails(string TypeID, string SubTypeID, string AppDate, string FirstName, string LastName, string PersalNo, string ComponentDetails, string ContactNumber, string AppEmail, string BOSR, string LossRef, string RefDate, string AssetNumber, string SerialNumber, string Description, string Unit, string ResponsibleNumber, string PremisesName, string CovertOvert, string PremisesSRNumber, string VSRNo, string VAssetNum, string TypeOfVehicle, string ResponsibleMember, string KilloMetreReading, string Vehicle, string VDescription, string TWVWPBU, string Model1, string Model2, string Model3, string Make1, string Make2, string Make3, string CreatedBy, string CreatedDate, string UpdatedBy, string UpdatedDate)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Insert into PSA_ApplicationDetails(TypeID,SubTypeID,AppDate,FirstName,LastName,PersalNo,ComponentDetails,ContactNumber,AppEmail,BOSR,LossRef,RefDate,AssetNumber,SerialNumber,Description,Unit,ResponsibleNumber,PremisesName,CovertOvert,PremisesSRNumber,VSRNo,VAssetNum,TypeOfVehicle,ResponsibleMember,KilloMetreReading,Vehicle,VDescription,TWVWPBU,Model1,Model2,Model3,Make1,Make2,Make3,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) Values "
                                      + $"({TypeID},{SubTypeID},'{AppDate}','{FirstName}','{LastName}','{PersalNo}','{ComponentDetails}','{ContactNumber}','{AppEmail}','{BOSR}','{LossRef}','{RefDate}','{AssetNumber}','{SerialNumber}','{Description}','{Unit}','{ResponsibleNumber}','{PremisesName}','{CovertOvert}','{PremisesSRNumber}','{VSRNo}','{VAssetNum}','{TypeOfVehicle}','{ResponsibleMember}','{KilloMetreReading}','{Vehicle}','{VDescription}','{TWVWPBU}','{Model1}','{Model2}','{Model3}','{Make1}','{Make2}','{Make3}','{CreatedBy}','{CreatedDate}','{UpdatedBy}','{UpdatedDate}')");
            return dt;
        }

        public DataTable UpdatePSV_ApplicationDetails(string ID ,string TypeID, string SubTypeID, string AppDate, string FirstName, string LastName, string PersalNo, string ComponentDetails, string ContactNumber, string AppEmail, string BOSR, string LossRef, string RefDate, string AssetNumber, string SerialNumber, string Description, string Unit, string ResponsibleNumber, string PremisesName, string CovertOvert, string PremisesSRNumber, string VSRNo, string VAssetNum, string TypeOfVehicle, string ResponsibleMember, string KilloMetreReading, string Vehicle, string VDescription, string TWVWPBU, string Model1, string Model2, string Model3, string Make1, string Make2, string Make3, string CreatedBy, string CreatedDate, string UpdatedBy, string UpdatedDate)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Update User set TypeID = " + TypeID +
              ", SubTypeID = " + SubTypeID +
                ", AppDate = '" + AppDate +
                "', FirstName = '" + FirstName +
                "', LastName = '" + LastName +
                "', PersalNo = " + PersalNo +
                ", ComponentDetails = '" + ComponentDetails +
                "', ContactNumber = '" + ContactNumber +
                "', AppEmail = '" + AppEmail +
                "', BOSR = '" + BOSR +
                "', LossRef = '" + LossRef +
                "', RefDate = '" + RefDate +
                "', AssetNumber = '" + AssetNumber +
                "', SerialNumber = '" + SerialNumber +
                "', Description = '" + Description +
                "', ContactNumber = '" + Unit +
                "', ResponsibleNumber = '" + ResponsibleNumber +
                "', PremisesName = '" + PremisesName +
                "', CovertOvert = '" + CovertOvert +
                "', PremisesSRNumber = '" + PremisesSRNumber +
                "', VSRNo = '" + VSRNo +
               "', VAssetNum = '" + VAssetNum +
               "', TypeOfVehicle = '" + TypeOfVehicle +
               "', ResponsibleMember = '" + ResponsibleMember +
               "', KilloMetreReading = '" + KilloMetreReading +
               "', Vehicle = '" + Vehicle +
               "', VDescription = '" + VDescription +
               "', TWVWPBU = '" + TWVWPBU +
               "', Model1 = '" + Model1 +
               "', Model2 = '" + Model2 +
               "', Model3 = '" + Model3 +
               "', Make1 = '" + Make1 +
               "', Make2 = '" + Make2 +
               "', Make3 = '" + Make3 +
                "', CreatedBy = '" + CreatedBy +
                "', CreatedDate = '" + CreatedDate +
                "', UpdatedBy = '" + UpdatedBy +
                "', UpdatedDate = '" + UpdatedDate +
                "', AppEmail = '" + AppEmail + "Where ID = " + ID);
            return dt;
        }

        public PSV_ApplicationDetails GetPSV_ApplicationDetails(string ID)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Select * from PSV_ApplicationDetails Where ID = " + ID);

            PSV_ApplicationDetails Details = new PSV_ApplicationDetails();

            Details.TypeID = dt.Rows[0][1].ToString();
            Details.SubTypeID = dt.Rows[0][2].ToString();
            Details.AppDate = dt.Rows[0][3].ToString();
            Details.FirstName = dt.Rows[0][4].ToString();
            Details.LastName = dt.Rows[0][5].ToString();
            Details.PersalNo = dt.Rows[0][6].ToString();
            Details.ComponentDetails = dt.Rows[0][7].ToString();
            Details.ContactNumber = dt.Rows[0][8].ToString();
            Details.AppEmail = dt.Rows[0][9].ToString();
            Details.BOSR = dt.Rows[0][10].ToString();
            Details.LossRef = dt.Rows[0][11].ToString();
            Details.RefDate = dt.Rows[0][12].ToString();
            Details.AssetNumber = dt.Rows[0][13].ToString();
            Details.SerialNumber = dt.Rows[0][14].ToString();
            Details.Description = dt.Rows[0][15].ToString();
            Details.Unit = dt.Rows[0][16].ToString();
            Details.ResponsibleNumber = dt.Rows[0][17].ToString();
            Details.PremisesName = dt.Rows[0][18].ToString();
            Details.CovertOvert = dt.Rows[0][19].ToString();
            Details.PremisesSRNumber = dt.Rows[0][20].ToString();
            Details.VSRNo = dt.Rows[0][21].ToString();
            Details.VAssetNum = dt.Rows[0][22].ToString();
            Details.TypeOfVehicle = dt.Rows[0][23].ToString();
            Details.ResponsibleMember = dt.Rows[0][24].ToString();
            Details.KilloMetreReading = dt.Rows[0][25].ToString();
            Details.Vehicle = dt.Rows[0][26].ToString();
            Details.VDescription = dt.Rows[0][27].ToString();
            Details.TWVWPBU = dt.Rows[0][28].ToString();
            Details.Model1 = dt.Rows[0][29].ToString();
            Details.Model2 = dt.Rows[0][30].ToString();
            Details.Model3 = dt.Rows[0][31].ToString();
            Details.Make1 = dt.Rows[0][32].ToString();
            Details.Make2 = dt.Rows[0][33].ToString();
            Details.Make3 = dt.Rows[0][34].ToString();
            Details.CreatedBy = dt.Rows[0][35].ToString();
            Details.CreatedDate = dt.Rows[0][36].ToString();
            Details.UpdatedBy = dt.Rows[0][37].ToString();
            Details.UpdatedDate = dt.Rows[0][38].ToString();
           
            return Details;

        }

        public PSA_ApplicationDetails GetPSA_ApplicationDetails(string ID)
        {
            DataTable dt = new DataTable();
            dt = ExecuteQueryFunction("Select * from PSA_ApplicationDetails Where ID = " + ID);

           PSA_ApplicationDetails Details = new PSA_ApplicationDetails();

            Details.TypeID = dt.Rows[0][1].ToString();
            Details.SubTypeID = dt.Rows[0][2].ToString();
            Details.AppDate = dt.Rows[0][3].ToString();
            Details.FirstName = dt.Rows[0][4].ToString();
            Details.LastName = dt.Rows[0][5].ToString();
            Details.PersalNo = dt.Rows[0][6].ToString();
            Details.ComponentDetails = dt.Rows[0][7].ToString();
            Details.ContactNumber = dt.Rows[0][8].ToString();
            Details.AppEmail = dt.Rows[0][9].ToString();
            Details.BOSR = dt.Rows[0][10].ToString();
            Details.LossRef = dt.Rows[0][11].ToString();
            Details.RefDate = dt.Rows[0][12].ToString();
            Details.AssetNumber = dt.Rows[0][13].ToString();
            Details.SerialNumber = dt.Rows[0][14].ToString();
            Details.Description = dt.Rows[0][15].ToString();
            Details.Unit = dt.Rows[0][16].ToString();
            Details.ResponsibleNumber = dt.Rows[0][17].ToString();
            Details.PremisesName = dt.Rows[0][18].ToString();
            Details.CovertOvert = dt.Rows[0][19].ToString();
            Details.PremisesSRNumber = dt.Rows[0][20].ToString();
            Details.Equipment = dt.Rows[0][21].ToString();
            Details.EquipmentDesc = dt.Rows[0][22].ToString();
            Details.NumberOfItems = dt.Rows[0][23].ToString();
            Details.CreatedBy = dt.Rows[0][24].ToString();
            Details.CreatedDate = dt.Rows[0][25].ToString();
            Details.UpdatedBy = dt.Rows[0][26].ToString();
          
            return Details;

        }


    }
}
