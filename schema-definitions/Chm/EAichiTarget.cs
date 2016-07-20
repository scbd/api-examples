// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
public class EAichiTarget
{
	[JsonProperty(Required=Required.Always)]
	public EHeader		header									{ get; set; }

	public int          number                  { get; set; }
	public lstring      title                   { get; set; }
	public lstring      shortTitle              { get; set; }
	public ELink[]      icons                   { get; set; }
	public ETerm        strategicGoal           { get; set; }

	public lstring      guide                        { get; set; }
	public EReference[] strategicPlanIndicators      { get; set; }
	public EReference[] otherStrategicPlanIndicators { get; set; }

	public lstring      progress				{ get; set; }
	public ELink[]      progressLinks			{ get; set; }

	public EAichiTarget_Champion[] champions    { get; set; }
	public EAichiTarget_Resource[] resources    { get; set; }

	public lstring      relevantInformation     { get; set; }
	public ELink[]      relevantDocuments       { get; set; }
	public string       notes                   { get; set; }

	public class EAichiTarget_Champion
	{
		public lstring		description		{ get; set; }
		public ETerm[]		countries		{ get; set; }
		public EReference[]	organizations	{ get; set; }
		public ELink[]		links			{ get; set; }
	}

	public class EAichiTarget_Resource
	{
		public lstring		description	{ get; set; }
		public EReference[]	references	{ get; set; }
		public ELink[]		links		{ get; set; }
		public ETerm[]		categories	{ get; set; }
	}
}