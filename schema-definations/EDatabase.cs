// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

	public class EDatabase
	{
		[JsonProperty(Required=Required.Always)]
		public EHeader		header				{ get; set; }

		public ETerm		government			{ get; set; }
		public ETerm[]		libraries			{ get; set; }
		public lstring		title				{ get; set; }
		public lstring		description			{ get; set; }
		public ELink		website				{ get; set; }
		public lstring		relevantInformation	{ get; set; }
		public ELink[]		relevantDocuments	{ get; set; }
		public string		notes				{ get; set; }
	}