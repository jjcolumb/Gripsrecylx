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

    public partial class SamplePackWeight : XPObject
    {
        decimal fQuantity;
        public decimal Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<decimal>(nameof(Quantity), ref fQuantity, value); }
        }
        EnumInstance fUnitOfMeas;
        [Association(@"SamplePackWeightReferencesEnumInstance3")]
        public EnumInstance UnitOfMeas
        {
            get { return fUnitOfMeas; }
            set { SetPropertyValue<EnumInstance>(nameof(UnitOfMeas), ref fUnitOfMeas, value); }
        }
        EnumInstance fType;
        [Association(@"SamplePackWeightReferencesEnumInstance2")]
        public EnumInstance Type
        {
            get { return fType; }
            set { SetPropertyValue<EnumInstance>(nameof(Type), ref fType, value); }
        }
        EnumInstance fMaterial;
        [Association(@"SamplePackWeightReferencesEnumInstance")]
        public EnumInstance Material
        {
            get { return fMaterial; }
            set { SetPropertyValue<EnumInstance>(nameof(Material), ref fMaterial, value); }
        }
        EnumInstance fMaterialCatery;
        [Persistent(@"MaterialCate ry")]
        [Association(@"SamplePackWeightReferencesEnumInstance1")]
        public EnumInstance MaterialCatery
        {
            get { return fMaterialCatery; }
            set { SetPropertyValue<EnumInstance>(nameof(MaterialCatery), ref fMaterialCatery, value); }
        }
        double fMinRecCon;
        public double MinRecCon
        {
            get { return fMinRecCon; }
            set { SetPropertyValue<double>(nameof(MinRecCon), ref fMinRecCon, value); }
        }
        double fMaxRecCon;
        public double MaxRecCon
        {
            get { return fMaxRecCon; }
            set { SetPropertyValue<double>(nameof(MaxRecCon), ref fMaxRecCon, value); }
        }
        double fAvgRecCon;
        public double AvgRecCon
        {
            get { return fAvgRecCon; }
            set { SetPropertyValue<double>(nameof(AvgRecCon), ref fAvgRecCon, value); }
        }
        double fMinPostCon;
        public double MinPostCon
        {
            get { return fMinPostCon; }
            set { SetPropertyValue<double>(nameof(MinPostCon), ref fMinPostCon, value); }
        }
        double fMaxPostCon;
        public double MaxPostCon
        {
            get { return fMaxPostCon; }
            set { SetPropertyValue<double>(nameof(MaxPostCon), ref fMaxPostCon, value); }
        }
        double fAvgPostCon;
        public double AvgPostCon
        {
            get { return fAvgPostCon; }
            set { SetPropertyValue<double>(nameof(AvgPostCon), ref fAvgPostCon, value); }
        }
        int fTonnesDivisor;
        public int TonnesDivisor
        {
            get { return fTonnesDivisor; }
            set { SetPropertyValue<int>(nameof(TonnesDivisor), ref fTonnesDivisor, value); }
        }
        SampleCatery fCatery;
        [Persistent(@"Cate ry")]
        [Association(@"SamplePackWeightReferencesSampleCatery")]
        public SampleCatery Catery
        {
            get { return fCatery; }
            set { SetPropertyValue<SampleCatery>(nameof(Catery), ref fCatery, value); }
        }
        int fMaterialCategory;
        public int MaterialCategory
        {
            get { return fMaterialCategory; }
            set { SetPropertyValue<int>(nameof(MaterialCategory), ref fMaterialCategory, value); }
        }
        SampleCategory fCategory;
        [Association(@"SamplePackWeightReferencesSampleCategory")]
        public SampleCategory Category
        {
            get { return fCategory; }
            set { SetPropertyValue<SampleCategory>(nameof(Category), ref fCategory, value); }
        }
    }

}
