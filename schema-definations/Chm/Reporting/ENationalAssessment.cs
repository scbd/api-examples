 // Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
   public class ENationalAssessment
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader          header              { get; set; }

        //common info
        public ETerm            government          { get; set; }
        public EReference       nationalTarget      { get; set; }

        public DateTime?        date	            { get; set; }

        public lstring          assessmentText      { get; set; }
		public ETerm            progress            { get; set; }
		public ETerm            confidence          { get; set; }
		public lstring          confidenceInfo      { get; set; }

        public EReference[]     strategicPlanIndicators   { get; set; }
        public EReferenceLinks[]nationalIndicators        { get; set; }
        public EReference[]     implementationActivities  { get; set; }

        public lstring          documentText       { get; set; }
        public ELink[]          documentLinks      { get; set; }

        public lstring          relevantInformation { get; set; }
        public ELink[]          relevantDocuments   { get; set; }
        public string[]         notes               { get; set; }
    }

	public class EReferenceLinks : EReference
	{
		public ELink[] links { get; set; }
        public lstring description { get; set; }
	}
