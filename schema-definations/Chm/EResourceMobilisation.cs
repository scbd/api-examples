// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

    public class EResourceMobilisation
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader                    header                                   { get; set; }
                                                                                   
        // document main information                                               
        public ETerm                      government                               { get; set; }
        public ETerm                      ownerBehalf                              { get; set; }
        public lstring                    title                                    { get; set; } 
        public bool                       hasAuthority                             { get; set; }               

        // respondent information                                                  
		public string                     respondentName                           { get; set; }
        public lstring                    respondentDesignation                    { get; set; }
        public lstring                    respondentDepartment                     { get; set; }
        public lstring                    respondentOrganization                   { get; set; }
        public string[]                   respondentEmails                         { get; set; }
        public string[]                   respondentPhones                         { get; set; }
        public DateTime                   completedDate                            { get; set; }
                                                                                   
        public lstring                    relevantInformation                      { get; set; }
        public ELink[]                    relevantDocuments                        { get; set; }
        public string[]                   notes                                    { get; set; }
                                                                                   
        public string                     hasPrivateSectorMeasures                 { get; set; }
        public lstring                    hasPrivateSectorMeasuresComments         { get; set; }
                                                                                   
        public string                     hasDomesticPrivateSectorMeasures         { get; set; }
        public lstring                    hasDomesticPrivateSectorMeasuresComments { get; set; }
        
        public string                     hasNationalBiodiversityInclusion         { get; set; }
        public lstring                    hasNationalBiodiversityInclusionComments { get; set; }
        
        public string                     hasBiodiversityAssessment                { get; set; }
        public lstring                    hasBiodiversityAssessmentComments        { get; set; }
                                                                                  
        public EInternationalResources    internationalResources                   { get; set; }
        public EDomesticExpendituresData  domesticExpendituresData                 { get; set; }
        public EFundingNeedsData          fundingNeedsData                         { get; set; }
        public ENationalPlansData         nationalPlansData                        { get; set; }
        public EFinancialAvailabilityData financialAvailabilityData                { get; set; }
    }

    //============================================================
    //
    //
    //============================================================
    public class EInternationalResources
    {
        public EBaselineData baselineData                     { get; set; }
        public EProgressData progressData                     { get; set; }
        public ETerm         currency                         { get; set; }
        public string        multiplier                       { get; set; }
        public string        hasPrivateSectorMeasures         { get; set; }
        public lstring       hasPrivateSectorMeasuresComments { get; set; }
        public ETerm[]       odaCategories                    { get; set; }
        public ETerm         odaOofType                       { get; set; }
        public ETerm[]       odaOofActions                    { get; set; }
        public ETerm[]       otherActions                     { get; set; }
        public ETerm         odaConfidenceLevel               { get; set; }
        public ETerm         oofConfidenceLevel               { get; set; }
        public ETerm         otherConfidenceLevel             { get; set; }
        public lstring       methodologicalComments           { get; set; }
    }

    //============================================================
    //
    //
    //============================================================
    public class EBaselineData
    {
        public EFinancialFlow[] financialFlows          { get; set; }       
        public string           methodologyUsed         { get; set; }       
        public lstring          methodologyUsedComments { get; set; }       
        public int              coefficient             { get; set; }       
    }

    //============================================================
    //
    //
    //============================================================
    public class EProgressData
    {
        public EFinancialFlow[] financialFlows       { get; set; }       
        public ETerm            odaConfidenceLevel   { get; set; }       
        public ETerm            oofConfidenceLevel   { get; set; }       
        public ETerm            otherConfidenceLevel { get; set; }       
    }

    //============================================================
    //
    //
    //============================================================
    public class EFinancialFlow
    {
        public int year        { get; set; }
        public decimal odaAmount   { get; set; }
        public decimal oofAmount   { get; set; }
        public decimal otherAmount { get; set; }
    }

    //============================================================
    //
    //
    //============================================================
    public class EDomesticExpendituresData
    {
        public EExpenditureContribution[] expenditures                                { get; set; }             
        public EExpenditureContribution[] contributions                               { get; set; }
        public ETerm                      currency                                    { get; set; }
        public string                     multiplier                                  { get; set; }
        public bool                       govCentralDirectlyRelated                   { get; set; }
        public bool                       provincialDirectlyRelated                   { get; set; }
        public bool                       municipalDirectlyRelated                    { get; set; }
        public bool                       extraDirectlyRelated                        { get; set; }
        public bool                       privateDirectlyRelated                      { get; set; }
        public bool                       otherDirectlyRelated                        { get; set; }
        public bool                       ilcDirectlyRelated                          { get; set; }
        public bool                       govCentralIndirectlyRelated                 { get; set; }
        public bool                       provincialIndirectlyRelated                 { get; set; }
        public bool                       municipalIndirectlyRelated                  { get; set; }
        public bool                       extraIndirectlyRelated                      { get; set; }
        public bool                       privateIndirectlyRelated                    { get; set; }
        public bool                       otherIndirectlyRelated                      { get; set; }
        public bool                       ilcIndirectlyRelated                        { get; set; }
        public lstring                    sourcesAdditionalComments                   { get; set; }
        public string                     domesticCollectiveAction                    { get; set; }
        public string                     measurementUnit                             { get; set; }
        public string                     domesticCollectiveActionMethodology         { get; set; }
        public lstring                    domesticCollectiveActionMethodologyOther    { get; set; }
        public lstring                    domesticCollectiveActionMethodologyComments { get; set; }
    }
    
    //============================================================
    //
    //
    //============================================================
    public class EExpenditureContribution
    {
        public int   year            { get; set; }
        public decimal amount        { get; set; }
        public ETerm confidenceLevel { get; set; }      
    }

    //============================================================
    //
    //
    //============================================================
    public class EFundingNeedsData
    {
        public ETerm              currency           { get; set; }
        public string             multiplier         { get; set; }
        public EAnnualEstimate[]  annualEstimates    { get; set; }
        public lstring            additionalComments { get; set; }
    }

    //============================================================
    //
    //
    //============================================================
    public class EAnnualEstimate
    {
        public int     year                     { get; set; }
        public decimal fundingNeedAmout         { get; set; }
        public decimal fundingGapAmount         { get; set; }
        public decimal availableResourcesAmount { get; set; }
        public lstring action                   { get; set; }
    }


    //============================================================
    //
    //
    //============================================================
    public class ENationalPlansData
    {
        public string             multiplier            { get; set; }
        public EFinancialSource[] domesticSources       { get; set; }
        public EFinancialSource[] internationalSources  { get; set; }
    }

    //============================================================
    //
    //
    //============================================================
    public class EFinancialSource
    {
        public decimal amount2014 { get; set; }
        public decimal amount2015 { get; set; }
        public decimal amount2016 { get; set; }
        public decimal amount2017 { get; set; }
        public decimal amount2018 { get; set; }
        public decimal amount2019 { get; set; }
        public decimal amount2020 { get; set; }
    }

    //============================================================
    //
    //
    //============================================================
    public class EFinancialAvailabilityData
    {
        public bool reportDomesticExpenditures { get; set; }
        public bool reportFundingNeeds         { get; set; }
        public bool prepareFinancePlans        { get; set; }
    }