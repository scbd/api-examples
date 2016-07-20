// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

    public class EStrategicPlanIndicator
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader		header	 { get; set; }
        //common info
        public lstring		title     { get; set; }
        public lstring		headline  { get; set; }
        public ELink[]		icon      { get; set; }

        public lstring		subTopic                  { get; set; }
        public lstring		communicationQuestion     { get; set; }
        public lstring		operationalClassification { get; set; }
        public lstring		developmentStatus         { get; set; }
        public lstring		progressStatus            { get; set; }

		public ETerm		sensitivity        { get; set; }
		public ETerm[]		scales             { get; set; }
		public ETerm		scientificValidity { get; set; }
		public ETerm		communicationLevel { get; set; }
        public ELink[]		linkToResources    { get; set; }

        public lstring		dataSources        { get; set; }
        public lstring		dataRequirements   { get; set; }

		public EReference	organizations           { get; set; }

        public lstring		relevantInformation     { get; set; }
        public ELink[]		relevantDocuments       { get; set; }
        public string		notes                   { get; set; }
    }
