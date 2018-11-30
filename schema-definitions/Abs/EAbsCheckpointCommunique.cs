// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
 public class EAbsCheckpointCommunique
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader          header                      { get; set; }

        public lstring title { get; set; }

        [Term("countries")]
        public ETerm            government                  { get; set; }
        [Reference("absPermit")]
        public EReference[]     absIRCCs                    { get; set; }
        [Reference("absCheckpoint")]
        public EReference[]     absCheckpoints              { get; set; }
        public bool             absIRCCsNotAvailable        { get; set; }
        [Term("countries")]
        public ETerm[]          sourceCountries             { get; set; }

        [Reference("contact", "authority")]
        public EReference       entityWhoGrantedPIC         { get; set; }
        
        public lstring          subjectMatter               { get; set; }
        public ELink[]          specimens                   { get; set; }
        public ELink[]          taxonomies                  { get; set; }
        public ELink[]          gisFiles                    { get; set; }
        public EMapLocation     gisMapCenter                { get; set; }
        [Reference("contact", "authority")]
        public EReference[]     personsAtCheckpoint         { get; set; }
        public lstring          evidenceOfPIC               { get; set; }
        public lstring          evidenceOfMAT               { get; set; }
        [Reference("contact", "authority")]
        public EReference       entityToWhomPICGranted      { get; set; }

        public lstring          description                 { get; set; }
        public DateTime?        dateOfAccess                { get; set; }
        public DateTime?        dateCollected               { get; set; }
        public DateTime?        dateCollectedFrom           { get; set; }
        public DateTime?        dateCollectedTo             { get; set; }

        public lstring          relevantInformation         { get; set; }
        public ELink[]          relevantDocuments           { get; set; }
        public string           notes                       { get; set; }

        [Term("1A22EAAB-9BBC-4543-890E-DEF913F59E98")]
        public ETerm[]          keywords                    { get; set; }
        public lstring          keywordOther                { get; set; }
    }

    public class EMapLocation
    {
        public int zoom { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class EAssessment
    {
        public string identifier { get; set; }
        public string level { get; set; }
        public lstring justification { get; set; }
    }

