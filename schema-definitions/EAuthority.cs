  // Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

  [Schema("authority")]
    public class EAuthority
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader      header                      { get; set; }
		[Term("countries")]
        public ETerm        government                  { get; set; }
        public lstring      name                        { get; set; }
        public ELink[]      websites                    { get; set; }
        public lstring      address                     { get; set; }
        public lstring      city                        { get; set; }
        public lstring      state                       { get; set; }
        public lstring      postalCode                  { get; set; }
		[Term("countries")]
        public ETerm        country                     { get; set; }
        public string[]     phones                      { get; set; }
        public string[]     faxes                       { get; set; }
        public string[]     emails                      { get; set; }
		[Reference("contact")]
        public EReference [] contacts                   { get; set; }

        public lstring      relevantInformation         { get; set; }
        public ELink[]      relevantDocuments           { get; set; }
        public string       notes                       { get; set; }

        //Common
        public lstring      responsibilities { get; set; }

		// ABS
        public bool         absResponsibleForAll { get; set; }
        public lstring      absPolicyBasisForCompetency     { get; set; }
        [Reference("measure")]
        public EReference[] absPolicyBasisForCompetencyRef  { get; set; }
		[Term("D7BD5BDE-A6B9-4261-B788-16839CCC4F7E")]
		public ETerm[]        absJurisdiction                 { get; set; }
		public lstring      absJurisdictionName             { get; set; }
		[Term("20945FA8-C24C-4AF6-B3D9-367592AFDF48")]
        public ETerm[]      absGeneticResourceTypes         { get; set; }
		[Term("545CD54C-CFF3-41E8-A003-FDD278426A3A")]
        public ETerm[]      absGeneticResourceAreas         { get; set; }

		// CPB (BCH)
		[Term("Subject Areas")]
        public ETerm[]      cpbFunctions                { get; set; }
		[Term("TypeOfOrganisms")]
        public ETerm[]      cpbOrganismTypes            { get; set; }

        [Obsolete]	public ETerm[]      libraries                   { get; set; }
    }
