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

    [OptimisticLocking(false)]
    public partial class ImportCrossReferenceLine : XPCustomObject
    {
        Guid fOid;
        [Key(true)]
        public Guid Oid
        {
            get { return fOid; }
            set { SetPropertyValue<Guid>(nameof(Oid), ref fOid, value); }
        }
        ImportCrossReference fImportCrossReference;
        [Association(@"ImportCrossReferenceLineReferencesImportCrossReference")]
        public ImportCrossReference ImportCrossReference
        {
            get { return fImportCrossReference; }
            set { SetPropertyValue<ImportCrossReference>(nameof(ImportCrossReference), ref fImportCrossReference, value); }
        }
        int fOrderNumber;
        public int OrderNumber
        {
            get { return fOrderNumber; }
            set { SetPropertyValue<int>(nameof(OrderNumber), ref fOrderNumber, value); }
        }
        string fImportValue;
        [Size(30)]
        public string ImportValue
        {
            get { return fImportValue; }
            set { SetPropertyValue<string>(nameof(ImportValue), ref fImportValue, value); }
        }
        string fOutputValue;
        [Size(60)]
        public string OutputValue
        {
            get { return fOutputValue; }
            set { SetPropertyValue<string>(nameof(OutputValue), ref fOutputValue, value); }
        }
        int fMatchingMode;
        public int MatchingMode
        {
            get { return fMatchingMode; }
            set { SetPropertyValue<int>(nameof(MatchingMode), ref fMatchingMode, value); }
        }
        bool fCaseSensitive;
        public bool CaseSensitive
        {
            get { return fCaseSensitive; }
            set { SetPropertyValue<bool>(nameof(CaseSensitive), ref fCaseSensitive, value); }
        }
    }

}