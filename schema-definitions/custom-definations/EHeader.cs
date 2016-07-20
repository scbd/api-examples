 // Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
   public class EHeader
    {
		[JsonProperty(Required=Required.Always)] public string   identifier  { get; set; } 
		[JsonProperty(Required=Required.Always)] public string   schema      { get; set; }
												 public string[] languages   { get; set; }
    }