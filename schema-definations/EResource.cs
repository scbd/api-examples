// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
	public class EResource
	{
		[JsonProperty(Required=Required.Always)]
		public EHeader		header					{ get; set; }

        public ETerm[]		resourceTypes			{ get; set; }
		public ETerm		fileFormat				{ get; set; }   // 3
        public lstring      formatDetails           { get; set; }   // 4
        public ETerm[]		purpose				    { get; set; }   // 5
        public ETerm[]		targetGroups 		    { get; set; }   // 6
        public ETerm		expertiseLevel		    { get; set; }   // 7

        public lstring		title					{ get; set; }   // 8
		public lstring		authors					{ get; set; }   // 9a
		public EReference[]	organizations           { get; set; }   // 9b
        public int			publicationYear			{ get; set; }   // 10
        public lstring		rights					{ get; set; }   // 11
        public lstring		source					{ get; set; }   // 12

        // access to the resource
        public ELink[]		resourceLinks			{ get; set; }   // 13
        public ELink[]		covers					{ get; set; }   // 14

        // information on the content of resource
		public lstring		summary					{ get; set; }   // 15
        public ETerm[]      regions                 { get; set; }   // 16
        public ETerm[]      aichiTargets            { get; set; }   // 17

        // keywords
		public ETerm[]		cbdSubjects				{ get; set; }
		public ETerm[]		absSubjects				{ get; set; }
        public ETerm[]      absKeyAreas             { get; set; }   // 18
		public ETerm[]		bchSubjects				{ get; set; }

        // other info 
        public lstring		relevantInformation		{ get; set; }
        public ELink[]		relevantDocuments		{ get; set; }
        public string		notes					{ get; set; }

        
        // OLD FIELDS 

        [Obsolete]		public ETerm[]		libraries				{ get; set; }
        [Obsolete]		public lstring		authorsInfo				{ get; set; }
        [Obsolete]		public ETerm[]		languages				{ get; set; }
        [Obsolete]		public lstring		publisher				{ get; set; }
		
        [Obsolete("replaced with fileFormat and formatDetails")]
        public lstring		format					{ get; set; }

        [Obsolete]      public lstring		keywords				{ get; set; }
        [Obsolete]		public lstring		resourceAccess			{ get; set; }
        [Obsolete]		public bool?		bchRaRecommend			{ get; set; }
        [Obsolete]		public ETerm[]		bchRaSubjects			{ get; set; }
        [Obsolete]		public bool?		bchRaForLmo				{ get; set; }
        [Obsolete]		public EReference[]	organisms				{ get; set; }
        [Obsolete]		public EReference[]	genes					{ get; set; }
        [Obsolete]		public EReference[]	modifiedOrganisms		{ get; set; }
        [Obsolete]      public lstring      resourceTypeName        { get; set; }
        [Obsolete]      public lstring      languageName            { get; set; }
	}