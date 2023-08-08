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

    public partial class RepakReturnLine : XPObject
    {
        string fReference;
        public string Reference
        {
            get { return fReference; }
            set { SetPropertyValue<string>(nameof(Reference), ref fReference, value); }
        }
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        RepakReturnLine fParentLine;
        [Association(@"RepakReturnLineReferencesRepakReturnLine")]
        public RepakReturnLine ParentLine
        {
            get { return fParentLine; }
            set { SetPropertyValue<RepakReturnLine>(nameof(ParentLine), ref fParentLine, value); }
        }
        RepakReturn fParentReturn;
        [Association(@"RepakReturnLineReferencesRepakReturn")]
        public RepakReturn ParentReturn
        {
            get { return fParentReturn; }
            set { SetPropertyValue<RepakReturn>(nameof(ParentReturn), ref fParentReturn, value); }
        }
        int fLineID;
        public int LineID
        {
            get { return fLineID; }
            set { SetPropertyValue<int>(nameof(LineID), ref fLineID, value); }
        }
        int fRowID;
        public int RowID
        {
            get { return fRowID; }
            set { SetPropertyValue<int>(nameof(RowID), ref fRowID, value); }
        }
        int fLineType;
        public int LineType
        {
            get { return fLineType; }
            set { SetPropertyValue<int>(nameof(LineType), ref fLineType, value); }
        }
        string fShortName;
        public string ShortName
        {
            get { return fShortName; }
            set { SetPropertyValue<string>(nameof(ShortName), ref fShortName, value); }
        }
        [Association(@"RepakReturnCellReferencesRepakReturnLine")]
        public XPCollection<RepakReturnCell> RepakReturnCells { get { return GetCollection<RepakReturnCell>(nameof(RepakReturnCells)); } }
        [Association(@"RepakReturnLineReferencesRepakReturnLine")]
        public XPCollection<RepakReturnLine> RepakReturnLineCollection { get { return GetCollection<RepakReturnLine>(nameof(RepakReturnLineCollection)); } }
        [Association(@"RepakReturnLineFilterReferencesRepakReturnLine")]
        public XPCollection<RepakReturnLineFilter> RepakReturnLineFilters { get { return GetCollection<RepakReturnLineFilter>(nameof(RepakReturnLineFilters)); } }
    }

}