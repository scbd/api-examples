 // Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
   public class ENationalIndicator
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader		header			{ get; set; }

        //common info
        public ETerm        government          { get; set; }
        public lstring      title               { get; set; }
        public lstring      description         { get; set; }
        public EReference[] strategicPlanIndicators    { get; set; }
        public lstring      documentInfo        { get; set; }

		//Additional information
        public lstring      relevantInformation { get; set; }
        public ELink[]      relevantDocuments   { get; set; }
    }
