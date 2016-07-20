// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
	public class EOrganization
	{
		[JsonProperty(Required=Required.Always)]
		public EHeader		header					{ get; set; }

		public lstring		acronym					{ get; set; }
		public lstring		name					{ get; set; }
		public EReference[]	contacts				{ get; set; }
		public EReference[]	linkedOrganizations		{ get; set; }
		public lstring		address					{ get; set; }
		public lstring		city					{ get; set; }
		public lstring		state					{ get; set; }
		public lstring		postalCode				{ get; set; }
		public ETerm		country					{ get; set; }
		public string[]		phones					{ get; set; }
		public string[]		faxes					{ get; set; }
		public string[]		emails					{ get; set; }
		public ELink []		websites				{ get; set; }
		public ETerm[]		libraries				{ get; set; }
		public ETerm		organizationType		{ get; set; }
		public ETerm[]		thematicAreas			{ get; set; }
		public ETerm[]		absThematicAreas		{ get; set; }

        public ELink []		profileLink				    { get; set; }
        public lstring      relevantInformation         { get; set; }
        public ELink[]      relevantDocuments           { get; set; }
        public string       notes                       { get; set; }
	}
