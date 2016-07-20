// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

    public class ECapacityBuildingIntitiative
    {
	    [JsonProperty(Required=Required.Always)]
		public EHeader           header                    { get; set; }
        public ETerm[]           libraries                 { get; set; }

                
        // general information                               
		public lstring           title                     { get; set; }  // 2
		public lstring           projectNumber             { get; set; }  // 3
        public GeographicScope   geographicScope           { get; set; }  // 4
        public ETerm             status                    { get; set; }  // 5

        public DateTime          startDate                 { get; set; }  // 6
        public DateTime          endDate                   { get; set; }  // 6
        public lstring           duration                  { get; set; }  // 6


        public bool              isImplementedByAgencies   { get; set; }  // 7
        public EReference[]      implementingAgencies      { get; set; }
        
        public bool              isExecutededByAgencies    { get; set; }  // 7
        public EReference[]      executingAgencies         { get; set; }

        public bool              isCollaboratededByPartners{ get; set; }  // 7
        public EReference[]      collaboratingPartners     { get; set; }

        public EContactRef[]     contacts                  { get; set; }  // 8
        public ETerm             type                      { get; set; }  // 9
        public lstring           typeInfo                  { get; set; }  // 9

        public ELink[]           projectDocument           { get; set; }  // 10

        // detailed information
		public lstring           description               { get; set; }  // 11
		public ETerm[]           targetGroups              { get; set; }  // 12
		public ETerm[]           categories                { get; set; }  // 13

        // information on funding
		public ETerm[]           fundingSourceTypes        { get; set; }  // 14
        public lstring           selfFundingInfo           { get; set; }  // 14
                                
        public EReference[]      coreFundingSources        { get; set; }  // 15
        public EReference[]      coFinancingSources        { get; set; }  // 16

        public string            totalBudget               { get; set; }  // 17 
        
        // capacity-building outcomes
               
		public lstring           resultsAchievements       { get; set; }  // 18
		public EReference[]      resultsReference          { get; set; }  // 18
        public ELink[]           resultsOutputs            { get; set; }  // 18

		public lstring           bestPractices             { get; set; }  // 19
                        
        // subject area(s) and the aichi biodiversity target(s) 
        public ETerm[]           cbdSubjects               { get; set; }  // 20 
        public ETerm[]           aichiTargets              { get; set; }  // 20

        // information in the thematic coverage of the initiatives

        // access to genetic resources and benefit-sharing-sharing (abs)
        public ETerm[]           absKeyAreas               { get; set; }  // 21

        // biosafety
        public ETerm[]           cpbThematicAreas          { get; set; }  // 22

        // additional information
        public lstring           relevantInformation       { get; set; }  // 24    
		public ELink[]           relevantDocuments         { get; set; }  // 24
		public string            notes                     { get; set; }  // 25
    }

    //============================================================
    //
    //
    //============================================================
    public class GeographicScope
    {
        public ETerm   scope                { get; set; }  
        public ETerm[] regionsOrCountries   { get; set; }
        public lstring jurisdiction         { get; set; }
        public lstring community            { get; set; }
    } 