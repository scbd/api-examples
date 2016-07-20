  // Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

  public class EAuthority
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader      header                      { get; set; }
        public ETerm        government                  { get; set; }
        public ETerm[]      libraries                   { get; set; }
        public lstring      name                        { get; set; }
        public ELink[]      websites                    { get; set; }
        public lstring      address                     { get; set; }
        public lstring      city                        { get; set; }
        public lstring      state                       { get; set; }
        public lstring      postalCode                  { get; set; }
        public ETerm        country                     { get; set; }
        public string[]     phones                      { get; set; }
        public string[]     faxes                       { get; set; }
        public string[]     emails                      { get; set; }
        public EReference [] contacts                   { get; set; }

        public lstring      relevantInformation         { get; set; }
        public ELink[]      relevantDocuments           { get; set; }
        public string       notes                       { get; set; }

        //Common
        public lstring      responsibilities { get; set; }

		// ABS
        public bool         absResponsibleForAll { get; set; }
        public lstring      absPolicyBasisForCompetency     { get; set; }
        public EReference[] absPolicyBasisForCompetencyRef  { get; set; }
		public ETerm[]        absJurisdiction                 { get; set; }
		public lstring      absJurisdictionName             { get; set; }
        public ETerm[]      absGeneticResourceTypes         { get; set; }
        public ETerm[]      absGeneticResourceAreas         { get; set; }

		// CPB (BCH)
        public ETerm[]      cpbFunctions                { get; set; }
        public ETerm[]      cpbOrganismTypes            { get; set; }

    }
