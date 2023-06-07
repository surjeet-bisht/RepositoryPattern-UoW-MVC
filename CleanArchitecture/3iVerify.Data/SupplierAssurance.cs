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
    
    public partial class SupplierAssurance
    {
        public int SupplierAssuranceID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public int AssuranceSchemeID { get; set; }
        public string SchemeName { get; set; }
        public Nullable<System.DateTime> DateChecked { get; set; }
        public Nullable<System.DateTime> LastAudit { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public string GradeAchieved { get; set; }
        public Nullable<int> CheckByUserID { get; set; }
        public string AssuranceNo { get; set; }
        public string CertFileName { get; set; }
        public bool IsAutoAssure { get; set; }
        public string SiteCode { get; set; }
        public Nullable<bool> AutoReminder { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public Nullable<System.DateTime> DateSent { get; set; }
        public Nullable<System.DateTime> DateUploaded { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
        public Nullable<bool> IsLatest { get; set; }
        public Nullable<bool> TransferToMfg { get; set; }
        public string SignInToken { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public string ApprovalCode { get; set; }
        public Nullable<bool> AutoRenewalSent { get; set; }
        public string AzureStorageURL { get; set; }
        public string CCList { get; set; }
        public Nullable<int> SupplierCertificationDocumentID { get; set; }
        public Nullable<int> SupplierQuestionnaireID { get; set; }
        public Nullable<int> RawMaterialID { get; set; }
        public Nullable<bool> IsUploadComplete { get; set; }
        public Nullable<int> ParentSupplierAssuranceID { get; set; }
    
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}