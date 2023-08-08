﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Gripsrecylx.Module.BusinessObjects.Company1
{

    public partial class User : XPObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fFirstName;
        public string FirstName
        {
            get { return fFirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref fFirstName, value); }
        }
        string fLastName;
        public string LastName
        {
            get { return fLastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref fLastName, value); }
        }
        string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        UserGroup fGroup;
        [Association(@"UserReferencesUserGroup")]
        public UserGroup Group
        {
            get { return fGroup; }
            set { SetPropertyValue<UserGroup>(nameof(Group), ref fGroup, value); }
        }
        [Association(@"BOMReferencesUser")]
        public XPCollection<BOM> BOMs { get { return GetCollection<BOM>(nameof(BOMs)); } }
        [Association(@"BOMReferencesUser1")]
        public XPCollection<BOM> BOMs1 { get { return GetCollection<BOM>(nameof(BOMs1)); } }
        [Association(@"ComplianceRuleReferencesUser")]
        public XPCollection<ComplianceRule> ComplianceRules { get { return GetCollection<ComplianceRule>(nameof(ComplianceRules)); } }
        [Association(@"ComplianceRuleReferencesUser1")]
        public XPCollection<ComplianceRule> ComplianceRules1 { get { return GetCollection<ComplianceRule>(nameof(ComplianceRules1)); } }
        [Association(@"CustomerReferencesUser")]
        public XPCollection<Customer> Customers { get { return GetCollection<Customer>(nameof(Customers)); } }
        [Association(@"CustomerReferencesUser1")]
        public XPCollection<Customer> Customers1 { get { return GetCollection<Customer>(nameof(Customers1)); } }
        [Association(@"DimCustomerReferencesUser")]
        public XPCollection<DimCustomer> DimCustomers { get { return GetCollection<DimCustomer>(nameof(DimCustomers)); } }
        [Association(@"DimCustomerReferencesUser1")]
        public XPCollection<DimCustomer> DimCustomers1 { get { return GetCollection<DimCustomer>(nameof(DimCustomers1)); } }
        [Association(@"DimItemTypeReferencesUser")]
        public XPCollection<DimItemType> DimItemTypes { get { return GetCollection<DimItemType>(nameof(DimItemTypes)); } }
        [Association(@"DimItemTypeReferencesUser1")]
        public XPCollection<DimItemType> DimItemTypes1 { get { return GetCollection<DimItemType>(nameof(DimItemTypes1)); } }
        [Association(@"DimMaterialReferencesUser")]
        public XPCollection<DimMaterial> DimMaterials { get { return GetCollection<DimMaterial>(nameof(DimMaterials)); } }
        [Association(@"DimMaterialReferencesUser1")]
        public XPCollection<DimMaterial> DimMaterials1 { get { return GetCollection<DimMaterial>(nameof(DimMaterials1)); } }
        [Association(@"DimPartTypeReferencesUser")]
        public XPCollection<DimPartType> DimPartTypes { get { return GetCollection<DimPartType>(nameof(DimPartTypes)); } }
        [Association(@"DimPartTypeReferencesUser1")]
        public XPCollection<DimPartType> DimPartTypes1 { get { return GetCollection<DimPartType>(nameof(DimPartTypes1)); } }
        [Association(@"DimProductReferencesUser")]
        public XPCollection<DimProduct> DimProducts { get { return GetCollection<DimProduct>(nameof(DimProducts)); } }
        [Association(@"DimProductReferencesUser1")]
        public XPCollection<DimProduct> DimProducts1 { get { return GetCollection<DimProduct>(nameof(DimProducts1)); } }
        [Association(@"EnumDomainReferencesUser")]
        public XPCollection<EnumDomain> EnumDomains { get { return GetCollection<EnumDomain>(nameof(EnumDomains)); } }
        [Association(@"EnumDomainReferencesUser1")]
        public XPCollection<EnumDomain> EnumDomains1 { get { return GetCollection<EnumDomain>(nameof(EnumDomains1)); } }
        [Association(@"EnumDomainSubsetReferencesUser")]
        public XPCollection<EnumDomainSubset> EnumDomainSubsets { get { return GetCollection<EnumDomainSubset>(nameof(EnumDomainSubsets)); } }
        [Association(@"EnumDomainSubsetReferencesUser1")]
        public XPCollection<EnumDomainSubset> EnumDomainSubsets1 { get { return GetCollection<EnumDomainSubset>(nameof(EnumDomainSubsets1)); } }
        [Association(@"EnumDomSubItemReferencesUser")]
        public XPCollection<EnumDomSubItem> EnumDomSubItems { get { return GetCollection<EnumDomSubItem>(nameof(EnumDomSubItems)); } }
        [Association(@"EnumDomSubItemReferencesUser1")]
        public XPCollection<EnumDomSubItem> EnumDomSubItems1 { get { return GetCollection<EnumDomSubItem>(nameof(EnumDomSubItems1)); } }
        [Association(@"EnumInstanceReferencesUser")]
        public XPCollection<EnumInstance> EnumInstances { get { return GetCollection<EnumInstance>(nameof(EnumInstances)); } }
        [Association(@"EnumInstanceReferencesUser1")]
        public XPCollection<EnumInstance> EnumInstances1 { get { return GetCollection<EnumInstance>(nameof(EnumInstances1)); } }
        [Association(@"FactPrimaryEndOfLifeReferencesUser")]
        public XPCollection<FactPrimaryEndOfLife> FactPrimaryEndOfLives { get { return GetCollection<FactPrimaryEndOfLife>(nameof(FactPrimaryEndOfLives)); } }
        [Association(@"FactPrimaryEndOfLifeReferencesUser1")]
        public XPCollection<FactPrimaryEndOfLife> FactPrimaryEndOfLives1 { get { return GetCollection<FactPrimaryEndOfLife>(nameof(FactPrimaryEndOfLives1)); } }
        [Association(@"FactSUPItemsReferencesUser")]
        public XPCollection<FactSUPItems> FactSUPItemsCollection { get { return GetCollection<FactSUPItems>(nameof(FactSUPItemsCollection)); } }
        [Association(@"FactSUPItemsReferencesUser1")]
        public XPCollection<FactSUPItems> FactSUPItemsCollection1 { get { return GetCollection<FactSUPItems>(nameof(FactSUPItemsCollection1)); } }
        [Association(@"IDASPackTotalReferencesUser")]
        public XPCollection<IDASPackTotal> IDASPackTotals { get { return GetCollection<IDASPackTotal>(nameof(IDASPackTotals)); } }
        [Association(@"IDASPackTotalReferencesUser1")]
        public XPCollection<IDASPackTotal> IDASPackTotals1 { get { return GetCollection<IDASPackTotal>(nameof(IDASPackTotals1)); } }
        [Association(@"MaterialMappingReferencesUser")]
        public XPCollection<MaterialMapping> MaterialMappings { get { return GetCollection<MaterialMapping>(nameof(MaterialMappings)); } }
        [Association(@"MaterialMappingReferencesUser1")]
        public XPCollection<MaterialMapping> MaterialMappings1 { get { return GetCollection<MaterialMapping>(nameof(MaterialMappings1)); } }
        [Association(@"RepakReturnCellReferencesUser")]
        public XPCollection<RepakReturnCell> RepakReturnCells { get { return GetCollection<RepakReturnCell>(nameof(RepakReturnCells)); } }
        [Association(@"RepakReturnCellReferencesUser1")]
        public XPCollection<RepakReturnCell> RepakReturnCells1 { get { return GetCollection<RepakReturnCell>(nameof(RepakReturnCells1)); } }
        [Association(@"RuleItemReferencesUser")]
        public XPCollection<RuleItem> RuleItems { get { return GetCollection<RuleItem>(nameof(RuleItems)); } }
        [Association(@"RuleItemReferencesUser1")]
        public XPCollection<RuleItem> RuleItems1 { get { return GetCollection<RuleItem>(nameof(RuleItems1)); } }
        [Association(@"SRAttributeReferencesUser")]
        public XPCollection<SRAttribute> SRAttributes { get { return GetCollection<SRAttribute>(nameof(SRAttributes)); } }
        [Association(@"SRAttributeReferencesUser1")]
        public XPCollection<SRAttribute> SRAttributes1 { get { return GetCollection<SRAttribute>(nameof(SRAttributes1)); } }
        [Association(@"SupplierReferencesUser")]
        public XPCollection<Supplier> Suppliers { get { return GetCollection<Supplier>(nameof(Suppliers)); } }
        [Association(@"SupplierReferencesUser1")]
        public XPCollection<Supplier> Suppliers1 { get { return GetCollection<Supplier>(nameof(Suppliers1)); } }
        [Association(@"TotalPackWeightReferencesUser")]
        public XPCollection<TotalPackWeight> TotalPackWeights { get { return GetCollection<TotalPackWeight>(nameof(TotalPackWeights)); } }
        [Association(@"TotalPackWeightReferencesUser1")]
        public XPCollection<TotalPackWeight> TotalPackWeights1 { get { return GetCollection<TotalPackWeight>(nameof(TotalPackWeights1)); } }
        [Association(@"UKReturnCellReferencesUser")]
        public XPCollection<UKReturnCell> UKReturnCells { get { return GetCollection<UKReturnCell>(nameof(UKReturnCells)); } }
        [Association(@"UKReturnCellReferencesUser1")]
        public XPCollection<UKReturnCell> UKReturnCells1 { get { return GetCollection<UKReturnCell>(nameof(UKReturnCells1)); } }
        [Association(@"UserPrivilegeReferencesUser")]
        public XPCollection<UserPrivilege> UserPrivileges { get { return GetCollection<UserPrivilege>(nameof(UserPrivileges)); } }
    }

}