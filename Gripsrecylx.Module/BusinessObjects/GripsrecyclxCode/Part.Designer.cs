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

    public partial class Part : XPObject
    {
        string fCode;
        public string Code
        {
            get { return fCode; }
            set { SetPropertyValue<string>(nameof(Code), ref fCode, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        Period fActiveFrom;
        [Association(@"PartReferencesPeriod")]
        public Period ActiveFrom
        {
            get { return fActiveFrom; }
            set { SetPropertyValue<Period>(nameof(ActiveFrom), ref fActiveFrom, value); }
        }
        Period fActiveTo;
        [Association(@"PartReferencesPeriod1")]
        public Period ActiveTo
        {
            get { return fActiveTo; }
            set { SetPropertyValue<Period>(nameof(ActiveTo), ref fActiveTo, value); }
        }
        PartGroup fPartGroup;
        [Association(@"PartReferencesPartGroup")]
        public PartGroup PartGroup
        {
            get { return fPartGroup; }
            set { SetPropertyValue<PartGroup>(nameof(PartGroup), ref fPartGroup, value); }
        }
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
        int fCreatedBy;
        public int CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<int>(nameof(CreatedBy), ref fCreatedBy, value); }
        }
        int fLastChangedBy;
        public int LastChangedBy
        {
            get { return fLastChangedBy; }
            set { SetPropertyValue<int>(nameof(LastChangedBy), ref fLastChangedBy, value); }
        }
        Company fCompany;
        [Association(@"PartReferencesCompany")]
        public Company Company
        {
            get { return fCompany; }
            set { SetPropertyValue<Company>(nameof(Company), ref fCompany, value); }
        }
        Part fParentComponent;
        [Association(@"PartReferencesPart")]
        public Part ParentComponent
        {
            get { return fParentComponent; }
            set { SetPropertyValue<Part>(nameof(ParentComponent), ref fParentComponent, value); }
        }
        int fPartType;
        public int PartType
        {
            get { return fPartType; }
            set { SetPropertyValue<int>(nameof(PartType), ref fPartType, value); }
        }
        [Association(@"BOMItemReferencesPart")]
        public XPCollection<BOMItem> BOMItems { get { return GetCollection<BOMItem>(nameof(BOMItems)); } }
        [Association(@"DimensionReferencesPart")]
        public XPCollection<Dimension> Dimensions { get { return GetCollection<Dimension>(nameof(Dimensions)); } }
        [Association(@"PackagingWeightReferencesPart")]
        public XPCollection<PackagingWeight> PackagingWeights { get { return GetCollection<PackagingWeight>(nameof(PackagingWeights)); } }
        [Association(@"PackWeightReferencesPart")]
        public XPCollection<PackWeight> PackWeights { get { return GetCollection<PackWeight>(nameof(PackWeights)); } }
        [Association(@"PartReferencesPart")]
        public XPCollection<Part> PartCollection { get { return GetCollection<Part>(nameof(PartCollection)); } }
        [Association(@"ProdWeightReferencesPart")]
        public XPCollection<ProdWeight> ProdWeights { get { return GetCollection<ProdWeight>(nameof(ProdWeights)); } }
        [Association(@"SRAttributeReferencesPart")]
        public XPCollection<SRAttribute> SRAttributes { get { return GetCollection<SRAttribute>(nameof(SRAttributes)); } }
    }

}
