using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcurementSystem.Models
{
    public class Assetco
    {
        public int ApplicationType { get; set; }
        public int CategoryType { get; set; }
        public int Date { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int PersalNo { get; set; }
        public int ComponentDetails { get; set; }
        public int EmailAddress { get; set; }
        public int Unit { get; set; }
        public int ResponsibleNumber { get; set; }
        public int PerimisesName { get; set; }
        public int CovertOvert { get; set; }
        public int BOSR { get; set; }
        public int LossReference { get; set; }
        public int RefDate { get; set; }
        public int SerialNumber { get; set; }
        public int Description { get; set; }
        public int SRNumber { get; set; }
        public int AssetNo { get; set; }
        public int TypeOfVehicle { get; set; }
        //

    }

    public class PSV_ApplicationDetails
    {
        public string TypeID { get; set; }
        public string SubTypeID { get; set; }
        public string AppDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersalNo { get; set; }
        public string ComponentDetails { get; set; }
        public string ContactNumber { get; set; }
        public string AppEmail { get; set; }
        public string BOSR { get; set; }
        public string LossRef { get; set; }
        public string RefDate { get; set; }
        public string AssetNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string ResponsibleNumber { get; set; }
        public string PremisesName { get; set; }
        public string CovertOvert { get; set; }
        public string PremisesSRNumber { get; set; }
        public string VSRNo { get; set; }
        public string VAssetNum { get; set; }
        public string TypeOfVehicle { get; set; }
        public string ResponsibleMember { get; set; }
        public string KilloMetreReading { get; set; }
        public string Vehicle { get; set; }
        public string VDescription { get; set; }
        public string TWVWPBU { get; set; }
        public string Model1 { get; set; }
        public string Model2 { get; set; }
        public string Model3 { get; set; }
        public string Make1 { get; set; }
        public string Make2 { get; set; }
        public string Make3 { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }

    public class PSA_ApplicationDetails
    {
        public string TypeID { get; set; }
        public string SubTypeID { get; set; }
        public string AppDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersalNo { get; set; }
        public string ComponentDetails { get; set; }
        public string ContactNumber { get; set; }
        public string AppEmail { get; set; }
        public string BOSR { get; set; }
        public string LossRef { get; set; }
        public string RefDate { get; set; }
        public string AssetNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string ResponsibleNumber { get; set; }
        public string PremisesName { get; set; }
        public string CovertOvert { get; set; }
        public string PremisesSRNumber { get; set; }
        public string Equipment { get; set; }
        public string EquipmentDesc { get; set; }
        public string NumberOfItems { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }
}
