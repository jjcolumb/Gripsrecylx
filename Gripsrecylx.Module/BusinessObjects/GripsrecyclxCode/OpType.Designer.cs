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

    public partial class OpType : XPObject
    {
        string fDisplayAs;
        public string DisplayAs
        {
            get { return fDisplayAs; }
            set { SetPropertyValue<string>(nameof(DisplayAs), ref fDisplayAs, value); }
        }
        string fValue;
        public string Value
        {
            get { return fValue; }
            set { SetPropertyValue<string>(nameof(Value), ref fValue, value); }
        }
        [Association(@"RuleItemReferencesOpType")]
        public XPCollection<RuleItem> RuleItems { get { return GetCollection<RuleItem>(nameof(RuleItems)); } }
    }

}
