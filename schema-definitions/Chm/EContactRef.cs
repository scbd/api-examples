// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

	public class EContactRef : EContactBase
	{
		public string	source { get; set; } // anything eg: identifier
		public string	type   { get; set; } // "organization" || "person" -> default "person"
		
		/*
		 * When type == person
		 * 	firstName & lastName are madatory
		 * 	
		 * When type == organization
		 *	organization is mandatory
		 */
	}
