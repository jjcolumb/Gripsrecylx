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

    public partial class DimItemType : XPObject
    {
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>(nameof(CreatedOn), ref fCreatedOn, value); }
        }
        DateTime fLastChangedOn;
        public DateTime LastChangedOn
        {
            get { return fLastChangedOn; }
            set { SetPropertyValue<DateTime>(nameof(LastChangedOn), ref fLastChangedOn, value); }
        }
        User fCreatedBy;
        [Association(@"DimItemTypeReferencesUser")]
        public User CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<User>(nameof(CreatedBy), ref fCreatedBy, value); }
        }
        User fLastChangedBy;
        [Association(@"DimItemTypeReferencesUser1")]
        public User LastChangedBy
        {
            get { return fLastChangedBy; }
            set { SetPropertyValue<User>(nameof(LastChangedBy), ref fLastChangedBy, value); }
        }
        Period fActiveFrom;
        [Association(@"DimItemTypeReferencesPeriod")]
        public Period ActiveFrom
        {
            get { return fActiveFrom; }
            set { SetPropertyValue<Period>(nameof(ActiveFrom), ref fActiveFrom, value); }
        }
        Period fActiveTo;
        [Association(@"DimItemTypeReferencesPeriod1")]
        public Period ActiveTo
        {
            get { return fActiveTo; }
            set { SetPropertyValue<Period>(nameof(ActiveTo), ref fActiveTo, value); }
        }
        Company fCompany;
        [Association(@"DimItemTypeReferencesCompany")]
        public Company Company
        {
            get { return fCompany; }
            set { SetPropertyValue<Company>(nameof(Company), ref fCompany, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fGroup_Level1;
        public string Group_Level1
        {
            get { return fGroup_Level1; }
            set { SetPropertyValue<string>(nameof(Group_Level1), ref fGroup_Level1, value); }
        }
        string fGroup_Level2;
        public string Group_Level2
        {
            get { return fGroup_Level2; }
            set { SetPropertyValue<string>(nameof(Group_Level2), ref fGroup_Level2, value); }
        }
        string fGroup_Level3;
        public string Group_Level3
        {
            get { return fGroup_Level3; }
            set { SetPropertyValue<string>(nameof(Group_Level3), ref fGroup_Level3, value); }
        }
        int fBaseOid;
        public int BaseOid
        {
            get { return fBaseOid; }
            set { SetPropertyValue<int>(nameof(BaseOid), ref fBaseOid, value); }
        }
        double fLongitude;
        public double Longitude
        {
            get { return fLongitude; }
            set { SetPropertyValue<double>(nameof(Longitude), ref fLongitude, value); }
        }
        double fLatitude;
        public double Latitude
        {
            get { return fLatitude; }
            set { SetPropertyValue<double>(nameof(Latitude), ref fLatitude, value); }
        }
        [Association(@"FactSUPItemsReferencesDimItemType")]
        public XPCollection<FactSUPItems> FactSUPItemsCollection { get { return GetCollection<FactSUPItems>(nameof(FactSUPItemsCollection)); } }
    }

}
