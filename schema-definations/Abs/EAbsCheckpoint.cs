// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
public class EAbsCheckpoint
{
    [JsonProperty(Required=Required.Always)]
    public EHeader      header                      { get; set; }

    public ETerm        government                  { get; set; }
    public lstring      name                        { get; set; }


    
    // ABS
    public lstring      responsibilities            { get; set; }
    public ETerm        jurisdiction                { get; set; }
    public lstring      jurisdictionName            { get; set; }
    public bool         informAllAuthorities        { get; set; }
    public EReference[] contactsToInform            { get; set; }

    public lstring relevantInformation { get; set; }
    public ELink[] relevantDocuments { get; set; }
    public string notes { get; set; }
}
