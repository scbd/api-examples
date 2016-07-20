// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
public class EMeasure
{
	[JsonProperty(Required=Required.Always)]
	public EHeader         header                                   { get; set; }

	public ETerm           government                               { get; set; }
	public ETerm[]         libraries                                { get; set; }
	public lstring         title                                    { get; set; }
	public lstring         description                              { get; set; }
	public ETerm           type                                     { get; set; }
	public ETerm           jurisdiction                             { get; set; }
	public ETerm[]         jurisdictionRegions                      { get; set; }
	public lstring         jurisdictionName                         { get; set; }
	public ELink[]         documents                                { get; set; }
	public ELink[]         documentTranslations                     { get; set; }
	public ETerm           status                                   { get; set; }
	public string          adoption                                 { get; set; } // Date
	public string          entryIntoForce                           { get; set; } // Date
	public string          retired                                  { get; set; } // Date
	public string          limitedApplication                       { get; set; } // Date
	public EReference[]    amendedMeasures                          { get; set; }
	public lstring         amendmentsDescription                    { get; set; }

	public EReference[]    linkedMeasures                           { get; set; }
	public lstring         linkedMeasuresDescription                { get; set; }
	public EReference[]    authorities                              { get; set; }
	public lstring         otherInformation                         { get; set; }
	public ELink[]         otherDocuments                           { get; set; }

	public lstring         relevantInformation                      { get; set; }
	public ELink[]         relevantDocuments                        { get; set; }
	public string          notes                                    { get; set; }

	public EAbsMeasure     absMeasures                              { get; set; }
	public bool            absMesasureNotApplicable                 { get; set; }

	//BCH
	public ETerm []        cpbSubjectAreas                          { get; set; }
	public ETerm []        cpbSubjectLmos                           { get; set; }

	public lstring          otherTypeName                           { get; set; }
	public bool             isAmendment                             { get; set; }
	public bool             isModelContractualClause                { get; set; }
	public lstring          isModelContractualClauseDescription     {get; set; }

	public lstring          otherAbsMeasure                         { get; set; }


	public class EAbsMeasure
	{
		public EGeneticResourceEelements[]  geneticResource { get; set; }
		public ETermSection[]               relevantElements { get; set; }
	}

	public class ETermSection : ETerm
	{
		public lstring  section         { get; set; }
		public string   parent          { get; set; }
		public bool     answer          { get; set; }
	}
			
	public class EGeneticResourceEelements
	{
		public ETerm[]  types   { get; set; }
		public ETerm[]  areas   { get; set; }
		public lstring  section { get; set; }
	}
	
}