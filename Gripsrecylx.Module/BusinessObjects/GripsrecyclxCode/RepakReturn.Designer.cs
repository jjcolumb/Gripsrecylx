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

    public partial class RepakReturn : XPObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        int fYear;
        public int Year
        {
            get { return fYear; }
            set { SetPropertyValue<int>(nameof(Year), ref fYear, value); }
        }
        string fPeriod;
        public string Period
        {
            get { return fPeriod; }
            set { SetPropertyValue<string>(nameof(Period), ref fPeriod, value); }
        }
        string fTemplate;
        public string Template
        {
            get { return fTemplate; }
            set { SetPropertyValue<string>(nameof(Template), ref fTemplate, value); }
        }
        [Association(@"RepakReturnLineReferencesRepakReturn")]
        public XPCollection<RepakReturnLine> RepakReturnLines { get { return GetCollection<RepakReturnLine>(nameof(RepakReturnLines)); } }
    }

}