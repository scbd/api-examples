// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
    public class EContact
	{
		[JsonProperty(Required=Required.Always)]
		public EHeader	header					    { get; set; } // * mandatory

        public string   type                        { get; set; } // "organization" || "person" * mandatory
        public EReference government                { get; set; }
        
        public lstring  relevantInformation         { get; set; }
        public ELink[]  relevantDocuments           { get; set; }
        public string   notes                       { get; set; }
        
        /////////////////////////////////////////////////////////////////////////////////////////
        // When type == person firstName & lastName are madatory
        /////////////////////////////////////////////////////////////////////////////////////////
        public lstring	prefix					{ get; set; }
        public string	firstName				{ get; set; }   // * mandatory only when type == person
        public string	middleName				{ get; set; }
        public string	lastName				{ get; set; }   // * mandatory only when type == person
        public EReference contactOrganization   { get; set; }
        public ETerm	gender					{ get; set; }
        public lstring	department				{ get; set; }
        public lstring	designation				{ get; set; }
        
        /////////////////////////////////////////////////////////////////////////////////////////
        // When type == organization organization is mandatory
        /////////////////////////////////////////////////////////////////////////////////////////
        public lstring	organization			{ get; set; }   // * mandatory only when type == organization
        public lstring	organizationAcronym		{ get; set; }
        public ETerm	organizationType		{ get; set; }
        
        /////////////////////////////////////////////////////////////////////////////////////////
        //  When type == person and contactOrganization is selected below info is not required           
        /////////////////////////////////////////////////////////////////////////////////////////
        public lstring	address					{ get; set; }
        public lstring	city					{ get; set; }
        public lstring	state					{ get; set; }
        public lstring	postalCode				{ get; set; }
        public ETerm	country					{ get; set; }   // * mandatory only when type == organization
        
        /////////////////////////////
        //// for any type of contact person/organization
        /////////////////////////////
        public string[]	phones					{ get; set; }
        public string[]	faxes					{ get; set; }
        public string[]	emails					{ get; set; }   // * mandatory
        public ELink []	websites				{ get; set; }
	}
