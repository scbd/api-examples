 // Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
   public class ELink
    {
		[JsonProperty(Required=Required.Always)]
        public string url       { get; set; }       // "http://www.cbd.int",
        public string name      { get; set; }       // "CBD"
        public string tags      { get; set; }       // 
    }