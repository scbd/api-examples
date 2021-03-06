﻿// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
	public class ETerm
	{
		[JsonProperty(Required=Required.Always)]
		public string       identifier      { get; set; }       //  "ca",
		public lstring      customValue     { get; set; }       //  { "en": "Nova Scotia", "fr": "Nouvelle-Écosse" }
	}
