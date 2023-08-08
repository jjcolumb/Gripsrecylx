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

    public partial class RuleItem : XPObject
    {
        int fSectorType;
        public int SectorType
        {
            get { return fSectorType; }
            set { SetPropertyValue<int>(nameof(SectorType), ref fSectorType, value); }
        }
        int fPackagingType;
        public int PackagingType
        {
            get { return fPackagingType; }
            set { SetPropertyValue<int>(nameof(PackagingType), ref fPackagingType, value); }
        }
        ComplianceRule fCompRule;
        [Association(@"RuleItemReferencesComplianceRule")]
        public ComplianceRule CompRule
        {
            get { return fCompRule; }
            set { SetPropertyValue<ComplianceRule>(nameof(CompRule), ref fCompRule, value); }
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
        User fCreatedBy;
        [Association(@"RuleItemReferencesUser")]
        public User CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<User>(nameof(CreatedBy), ref fCreatedBy, value); }
        }
        User fLastChangedBy;
        [Association(@"RuleItemReferencesUser1")]
        public User LastChangedBy
        {
            get { return fLastChangedBy; }
            set { SetPropertyValue<User>(nameof(LastChangedBy), ref fLastChangedBy, value); }
        }
        Period fActiveFrom;
        [Association(@"RuleItemReferencesPeriod")]
        public Period ActiveFrom
        {
            get { return fActiveFrom; }
            set { SetPropertyValue<Period>(nameof(ActiveFrom), ref fActiveFrom, value); }
        }
        Period fActiveTo;
        [Association(@"RuleItemReferencesPeriod1")]
        public Period ActiveTo
        {
            get { return fActiveTo; }
            set { SetPropertyValue<Period>(nameof(ActiveTo), ref fActiveTo, value); }
        }
        double fAllocationPercent;
        public double AllocationPercent
        {
            get { return fAllocationPercent; }
            set { SetPropertyValue<double>(nameof(AllocationPercent), ref fAllocationPercent, value); }
        }
        string fCondition;
        public string Condition
        {
            get { return fCondition; }
            set { SetPropertyValue<string>(nameof(Condition), ref fCondition, value); }
        }
        OpProperty fOpProperty;
        [Association(@"RuleItemReferencesOpProperty")]
        public OpProperty OpProperty
        {
            get { return fOpProperty; }
            set { SetPropertyValue<OpProperty>(nameof(OpProperty), ref fOpProperty, value); }
        }
        OpType fOpType;
        [Association(@"RuleItemReferencesOpType")]
        public OpType OpType
        {
            get { return fOpType; }
            set { SetPropertyValue<OpType>(nameof(OpType), ref fOpType, value); }
        }
        string fOpValue;
        public string OpValue
        {
            get { return fOpValue; }
            set { SetPropertyValue<string>(nameof(OpValue), ref fOpValue, value); }
        }
        OpOperator fOpOperator;
        [Association(@"RuleItemReferencesOpOperator")]
        public OpOperator OpOperator
        {
            get { return fOpOperator; }
            set { SetPropertyValue<OpOperator>(nameof(OpOperator), ref fOpOperator, value); }
        }
        Company fCompany;
        [Association(@"RuleItemReferencesCompany")]
        public Company Company
        {
            get { return fCompany; }
            set { SetPropertyValue<Company>(nameof(Company), ref fCompany, value); }
        }
    }

}
