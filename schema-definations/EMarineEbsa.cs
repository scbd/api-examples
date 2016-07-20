// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
	public class EMarineEbsa
	{
		[JsonProperty(Required=Required.Always)]
		public EHeader		header									{ get; set; }

		public lstring		title									{ get; set; }
		public lstring		summary									{ get; set; }
		public lstring		areaIntroducion							{ get; set; }
		public lstring		location								{ get; set; }
		public ELink[]		gisFiles								{ get; set; }
		public EMapLocation	gisMapCenter							{ get; set; }
		public lstring		areaDescription							{ get; set; }
		public lstring		areaConditions							{ get; set; }
		public lstring		areaFeatures							{ get; set; }
		public ETerm[]		countries								{ get; set; }
		public bool			beyondNationalJurisdiction				{ get; set; }
		public lstring		referenceText							{ get; set; }
		public EReference[]	resources								{ get; set; }
		public ELink[]		relation								{ get; set; }
		public string		status									{ get; set; }
		public EReference	approvedByCopDecision					{ get; set; }
		public ETerm		approvedByGovernment					{ get; set; }
		public DateTime		approvedByGovernmentOn					{ get; set; }
		public EReference	recommendedToCopBySbstta				{ get; set; }
		public ETerm		recommendedToCopByGovernment			{ get; set; }
		public DateTime		recommendedToCopByGovernmentOn			{ get; set; }

		public string		recommendedToSbsttaBy					{ get; set; }
		public EReference	recommendedToSbsttaByWorkshop			{ get; set; }

		public string		recommendedToWorkshopBy					{ get; set; }
		public ETerm[]		recommendedToWorkshopByGovernments		{ get; set; }
		public EReference[]	recommendedToWorkshopByOrganizations	{ get; set; }
		public lstring		recommendedToWorkshopByOthers			{ get; set; }
		
		public string		recommendedToAnyBy						{ get; set; }
		public ETerm[]		recommendedToAnyByGovernment			{ get; set; }
		public EReference[]	recommendedToAnyByOrganizations			{ get; set; }
		public lstring		recommendedToAnyByOthers				{ get; set; }

		public EAssessment[]	assessments					 			{ get; set; }
		public lstring			relevantInformation						{ get; set; }
		public ELink[]			relevantDocuments						{ get; set; }
		public string			notes									{ get; set; }



        public EReference   region                                 { get; set; }

		public class EMapLocation : EGeoLocation
		{
			public int zoom {get; set;}
		}

		public class EAssessment
		{
			public string	identifier		{get; set;}
			public string	level			{get; set;}
			public lstring	justification	{get; set;}
		}
	}
