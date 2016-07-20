// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

    public class ECaseStudy
    {
		[JsonProperty(Required=Required.Always)]
		public EHeader		header						{ get; set; }

        public lstring          title	                { get; set; }
        public ETerm[]          subjects                { get; set; }
        public EReference[]     aichiTargets            { get; set; }
        public ETerm[]          regions                 { get; set; }
        public ETerm[]          countries               { get; set; }

        public ETerm[]          languages               { get; set; }
        public DateTime?        startDate               { get; set; }
        public DateTime?        endDate                 { get; set; }
        public lstring          source                  { get; set; }
        public EReference[]     organizations           { get; set; }
        public EReference       contact                 { get; set; }


        public lstring          summary                 { get; set; }
        public lstring          description             { get; set; }
        public ETerm            scale                   { get; set; }
        public ETerm            status                  { get; set; }
        public EReference[]     resources               { get; set; }
        public ELink[]          images                  { get; set; }

        public lstring          relevantInformation     { get; set; }
        public ELink[]          relevantDocuments       { get; set; }
        public string           notes                   { get; set; }
    }
