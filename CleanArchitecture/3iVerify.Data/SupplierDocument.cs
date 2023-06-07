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
    
    public partial class SupplierDocument
    {
        public int SupplierDocumentID { get; set; }
        public int SupplierID { get; set; }
        public Nullable<int> SupplierDocumentTypeID { get; set; }
        public string DocumentShortName { get; set; }
        public string DocumentName { get; set; }
        public string Tags { get; set; }
        public System.DateTime DateUploaded { get; set; }
        public string UploadedBy { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> InDevelopment { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public Nullable<int> RawMaterialID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string AzureStorageURL { get; set; }
        public Nullable<bool> IsArchived { get; set; }
        public string ArchivedReason { get; set; }
        public Nullable<System.DateTime> ArchivedDate { get; set; }
        public string ArchivedBy { get; set; }
        public Nullable<bool> IsNoExpiry { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
        public Nullable<int> ExpiredDocumentID { get; set; }
    
        public virtual Supplier Supplier { get; set; }
    }
}
