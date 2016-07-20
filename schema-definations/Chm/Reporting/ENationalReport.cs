// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
public class ENationalReport
{
    [JsonProperty(Required=Required.Always)]
    public EHeader          header                  { get; set; }

    //common info
    public ETerm            government              { get; set; }
    public lstring          title                   { get; set; }
    public ETerm            reportType              { get; set; } //nbsap, national report, powpa action plan
    public lstring          summary                 { get; set; } 
    public ETerm            jurisdiction            { get; set; }
    public lstring          jurisdictionInfo        { get; set; }


    //report info
    public DateTime?        startDate               { get; set; }
    public DateTime?        endDate                 { get; set; }
    public ETerm            status                  { get; set; }
    public string           completionYear          { get; set; }
    public string           adoptionDate            { get; set; }
    public ETerm            approvedStatus          { get; set; }
    public ETerm            approvingBody           { get; set; }
    public lstring          approvingBodyInfo       { get; set; }
    
    //public EReference[]     partners                { get; set; }
    public lstring          documentText            { get; set; }
    public ELink[]          documentLinks          { get; set; }
    public lstring          relevantInformation { get; set; }
    public ELink[]          relevantDocuments   { get; set; }
    public string[]         notes               { get; set; }
}
