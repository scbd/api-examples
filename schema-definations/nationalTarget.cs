// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
public class ENationalTarget
{
    [JsonProperty(Required=Required.Always)]
    public EHeader		header				{ get; set; }

    //common info
    public ETerm        government              { get; set; }
    public lstring      title                   { get; set; } 
    public lstring      description             { get; set; }
    public ETerm        jurisdiction            { get; set; }
    public lstring      jurisdictionInfo        { get; set; }

    //target info
    public EReference[] aichiTargets                { get; set; }
    public EReference[] otherAichiTargets           { get; set; }

    public lstring      relevantInformation { get; set; }
    public ELink[]      relevantDocuments   { get; set; }
    public string[]     notes               { get; set; }


    public bool         isAichiTarget       { get; set; }
}