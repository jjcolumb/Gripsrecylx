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

    public partial class PackWeight : XPObject
    {
        decimal fQuantity;
        public decimal Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<decimal>(nameof(Quantity), ref fQuantity, value); }
        }
        int fUnitOfMeas;
        public int UnitOfMeas
        {
            get { return fUnitOfMeas; }
            set { SetPropertyValue<int>(nameof(UnitOfMeas), ref fUnitOfMeas, value); }
        }
        int fType;
        public int Type
        {
            get { return fType; }
            set { SetPropertyValue<int>(nameof(Type), ref fType, value); }
        }
        int fMaterial;
        public int Material
        {
            get { return fMaterial; }
            set { SetPropertyValue<int>(nameof(Material), ref fMaterial, value); }
        }
        Part fPart;
        [Association(@"PackWeightReferencesPart")]
        public Part Part
        {
            get { return fPart; }
            set { SetPropertyValue<Part>(nameof(Part), ref fPart, value); }
        }
        int fMaterialCatery;
        [Persistent(@"MaterialCate ry")]
        public int MaterialCatery
        {
            get { return fMaterialCatery; }
            set { SetPropertyValue<int>(nameof(MaterialCatery), ref fMaterialCatery, value); }
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
        string fForestryCertified;
        public string ForestryCertified
        {
            get { return fForestryCertified; }
            set { SetPropertyValue<string>(nameof(ForestryCertified), ref fForestryCertified, value); }
        }
        bool fMaterialRecyclable;
        public bool MaterialRecyclable
        {
            get { return fMaterialRecyclable; }
            set { SetPropertyValue<bool>(nameof(MaterialRecyclable), ref fMaterialRecyclable, value); }
        }
        bool fRefillable;
        public bool Refillable
        {
            get { return fRefillable; }
            set { SetPropertyValue<bool>(nameof(Refillable), ref fRefillable, value); }
        }
        bool fHeavyMetalComp;
        public bool HeavyMetalComp
        {
            get { return fHeavyMetalComp; }
            set { SetPropertyValue<bool>(nameof(HeavyMetalComp), ref fHeavyMetalComp, value); }
        }
        bool fConflictMetalComp;
        public bool ConflictMetalComp
        {
            get { return fConflictMetalComp; }
            set { SetPropertyValue<bool>(nameof(ConflictMetalComp), ref fConflictMetalComp, value); }
        }
        bool fBioDegrad;
        public bool BioDegrad
        {
            get { return fBioDegrad; }
            set { SetPropertyValue<bool>(nameof(BioDegrad), ref fBioDegrad, value); }
        }
        string fOnPackSustMsg;
        public string OnPackSustMsg
        {
            get { return fOnPackSustMsg; }
            set { SetPropertyValue<string>(nameof(OnPackSustMsg), ref fOnPackSustMsg, value); }
        }
        string fPlacePackFill;
        public string PlacePackFill
        {
            get { return fPlacePackFill; }
            set { SetPropertyValue<string>(nameof(PlacePackFill), ref fPlacePackFill, value); }
        }
        string fPlaceManufac;
        public string PlaceManufac
        {
            get { return fPlaceManufac; }
            set { SetPropertyValue<string>(nameof(PlaceManufac), ref fPlaceManufac, value); }
        }
        string fColour;
        public string Colour
        {
            get { return fColour; }
            set { SetPropertyValue<string>(nameof(Colour), ref fColour, value); }
        }
        decimal fSAPQuantity;
        public decimal SAPQuantity
        {
            get { return fSAPQuantity; }
            set { SetPropertyValue<decimal>(nameof(SAPQuantity), ref fSAPQuantity, value); }
        }
        int fMaterialCategory;
        public int MaterialCategory
        {
            get { return fMaterialCategory; }
            set { SetPropertyValue<int>(nameof(MaterialCategory), ref fMaterialCategory, value); }
        }
    }

}
