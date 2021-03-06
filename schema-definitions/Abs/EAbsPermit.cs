﻿// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

[Schema("absPermit")]
public class EAbsPermit
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader              header                                  { get; set; }

        [Term("countries")]
		public ETerm                government                              { get; set; }
        public lstring              updateReasons                           { get; set; }
        [Reference("authority")]
        public EReference           absCNA                                  { get; set; }
        public lstring              title                                   { get; set; }
        public lstring              referenceToNationalPermit               { get; set; }
        public DateTime?            dateOfIssuance                          { get; set; }

        [Reference("contact", "authority")]
        public EReference[]         providers                               { get; set; }
        public bool                 providersConfidential                    { get; set; }

        [Reference("contact", "authority")]
        public EReference[]         entitiesToWhomPICGranted                { get; set; }
        public bool                 entitiesToWhomPICGrantedConfidential    { get; set; }
        public lstring              subjectMatter                           { get; set; }
        public bool                 subjectMatterConfidential               { get; set; }
		[Term("1A22EAAB-9BBC-4543-890E-DEF913F59E98")]
        public ETerm[]              keywords                                { get; set; }
        public lstring              keywordOther                            { get; set; }

        public ELink[]              specimens                               { get; set; }
        public ELink[]              taxonomies                              { get; set; }
		public ELink[]		        gisFiles								{ get; set; }
		public EMapLocation	        gisMapCenter							{ get; set; }

        public AmendmentIntent      amendmentIntent                         { get; set; }
		public lstring              amendmentDescription                    { get; set; }

        public bool?                picGranted                              { get; set; }
        public lstring              picInformation                          { get; set; }
        public ELink[]              picDocuments                            { get; set; }
        public bool?                matEstablished                          { get; set; }
        public lstring              matInformation                          { get; set; }
        public ELink[]              matDocuments                            { get; set; }

        [Term("A7B77788-8C90-4849-9327-E181E9522F3A")]
        public ETerm[]              usages                                  { get; set; }
        public bool                 usagesConfidential                      { get; set; }
        public lstring              usagesDescription                       { get; set; }
        public lstring              thirdPartyTransferCondition             { get; set; }
        public DateTime?            dateOfExpiry                            { get; set; }
        public ELink[]              permitFiles                             { get; set; }
        public lstring              permitDescription                       { get; set; }               

        public lstring              relevantInformation                     { get; set; }
        public ELink[]              relevantDocuments                       { get; set; }
        public string               notes                                   { get; set; }

        [Reference("absPermit")]
        public EReference[]         relatedIRCCs                            { get; set; }
      
        public enum AmendmentIntent { 
           // New,
            Update,
            Revoke
        }

	    public class EMapLocation
		{
			public int		zoom	{get; set;}
			public double	lat		{get; set;}
			public double	lng		{get; set;}
		}

		public class EAssessment
		{
			public string	identifier		{get; set;}
			public string	level			{get; set;}
			public lstring	justification	{get; set;}
		}
	}
}
