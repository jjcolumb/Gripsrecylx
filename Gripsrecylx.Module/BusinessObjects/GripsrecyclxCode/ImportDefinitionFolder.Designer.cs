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

    public partial class ImportDefinitionFolder : XPCustomObject
    {
        Guid fOid;
        [Key(true)]
        public Guid Oid
        {
            get { return fOid; }
            set { SetPropertyValue<Guid>(nameof(Oid), ref fOid, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fFolderPath;
        [Size(254)]
        public string FolderPath
        {
            get { return fFolderPath; }
            set { SetPropertyValue<string>(nameof(FolderPath), ref fFolderPath, value); }
        }
        string fErrorFolderPath;
        [Size(254)]
        public string ErrorFolderPath
        {
            get { return fErrorFolderPath; }
            set { SetPropertyValue<string>(nameof(ErrorFolderPath), ref fErrorFolderPath, value); }
        }
        string fProcessedFolderPath;
        [Size(254)]
        public string ProcessedFolderPath
        {
            get { return fProcessedFolderPath; }
            set { SetPropertyValue<string>(nameof(ProcessedFolderPath), ref fProcessedFolderPath, value); }
        }
        string fLookupCode;
        [Size(50)]
        public string LookupCode
        {
            get { return fLookupCode; }
            set { SetPropertyValue<string>(nameof(LookupCode), ref fLookupCode, value); }
        }
        bool fIsActive;
        public bool IsActive
        {
            get { return fIsActive; }
            set { SetPropertyValue<bool>(nameof(IsActive), ref fIsActive, value); }
        }
        ImportDefinition fImportDefinition;
        [Association(@"ImportDefinitionFolderReferencesImportDefinition")]
        public ImportDefinition ImportDefinition
        {
            get { return fImportDefinition; }
            set { SetPropertyValue<ImportDefinition>(nameof(ImportDefinition), ref fImportDefinition, value); }
        }
    }

}
