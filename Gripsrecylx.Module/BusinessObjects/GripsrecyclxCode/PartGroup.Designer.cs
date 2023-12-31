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

    public partial class PartGroup : XPObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        int fParentId;
        public int ParentId
        {
            get { return fParentId; }
            set { SetPropertyValue<int>(nameof(ParentId), ref fParentId, value); }
        }
        PartGroup fParent;
        [Association(@"PartGroupReferencesPartGroup")]
        public PartGroup Parent
        {
            get { return fParent; }
            set { SetPropertyValue<PartGroup>(nameof(Parent), ref fParent, value); }
        }
        Company fCompany;
        [Association(@"PartGroupReferencesCompany")]
        public Company Company
        {
            get { return fCompany; }
            set { SetPropertyValue<Company>(nameof(Company), ref fCompany, value); }
        }
        [Association(@"PartReferencesPartGroup")]
        public XPCollection<Part> Parts { get { return GetCollection<Part>(nameof(Parts)); } }
        [Association(@"PartGroupReferencesPartGroup")]
        public XPCollection<PartGroup> PartGroupCollection { get { return GetCollection<PartGroup>(nameof(PartGroupCollection)); } }
    }

}
