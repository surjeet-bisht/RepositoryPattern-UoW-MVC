//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleanArchitecture.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class RawMaterial
    {
        public RawMaterial()
        {
            this.RawMaterialManufacturers = new HashSet<RawMaterialManufacturer>();
            this.RawMaterialSuppliers = new HashSet<RawMaterialSupplier>();
            this.RawMaterialSuppliers1 = new HashSet<RawMaterialSupplier>();
            this.SupplierQuestionnaires = new HashSet<SupplierQuestionnaire>();
        }
    
        public int RawMaterialID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string RawMaterial1 { get; set; }
        public string Variety { get; set; }
        public string Brand { get; set; }
        public string PackSize { get; set; }
        public string Packaging { get; set; }
        public string LegalName { get; set; }
        public string RawMaterialDescription { get; set; }
        public string IngrDeclaration { get; set; }
        public string RawMaterialOrganicDescription { get; set; }
        public Nullable<int> RawMaterialShelfLifeID { get; set; }
        public string RawMaterialSAPCode { get; set; }
        public string CommercialCode { get; set; }
        public Nullable<bool> IsReadyToEat { get; set; }
        public Nullable<bool> IsBulkProduct { get; set; }
        public string SupplierProductCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierFDARegNo { get; set; }
        public string DateCodeFormat { get; set; }
        public string BatchLotCodeDetail { get; set; }
        public string ShelfLifeDesignation { get; set; }
        public string ShelfLifeUnopened { get; set; }
        public string ShelfLifeOpened { get; set; }
        public string DistributionChain { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerFDARegNo { get; set; }
        public Nullable<int> FSVPExemptYesNoOnlyListID { get; set; }
        public Nullable<int> FSVPInPlaceYesNoListID { get; set; }
        public string FSVPDocumentName { get; set; }
        public string CountryOfOrigin { get; set; }
        public Nullable<int> CountryOfOriginID { get; set; }
        public string CountryOfTransit { get; set; }
        public Nullable<int> CountryOfTransitID { get; set; }
        public string CountryOfManufacture { get; set; }
        public Nullable<int> CountryOfManufactureID { get; set; }
        public Nullable<bool> Approved { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<int> ApprovedUserID { get; set; }
        public string ApprovalBasis { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string Comments { get; set; }
        public string ImportID { get; set; }
        public string GTIN { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
        public string DocumentPath { get; set; }
        public byte[] RawMaterialDocument { get; set; }
        public Nullable<bool> InDevelopment { get; set; }
        public string RawMaterialURL { get; set; }
        public string ServingsPerContainer { get; set; }
        public string ServingSize { get; set; }
        public Nullable<int> FSVPDocumentFileNameID { get; set; }
        public Nullable<bool> IsGlobal { get; set; }
        public Nullable<int> KBFoodSubCategoryID { get; set; }
        public Nullable<int> RawMaterialTypeID { get; set; }
        public Nullable<bool> IsWIP { get; set; }
        public Nullable<bool> IsPackaging { get; set; }
        public string MethodOfProduction { get; set; }
        public Nullable<int> MaterialUnitTypeID { get; set; }
        public Nullable<decimal> SpecificGravity { get; set; }
        public Nullable<int> GS1FoodSubCategoryID { get; set; }
        public Nullable<int> RawMaterialRiskCategoryID { get; set; }
        public Nullable<decimal> MaterialUnitNetWtKg { get; set; }
        public Nullable<decimal> PlasticTaxGramsPerKg { get; set; }
    
        public virtual ICollection<RawMaterialManufacturer> RawMaterialManufacturers { get; set; }
        public virtual ICollection<RawMaterialSupplier> RawMaterialSuppliers { get; set; }
        public virtual ICollection<RawMaterialSupplier> RawMaterialSuppliers1 { get; set; }
        public virtual ICollection<SupplierQuestionnaire> SupplierQuestionnaires { get; set; }
    }
}
