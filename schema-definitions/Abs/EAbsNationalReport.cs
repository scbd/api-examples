// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
public class EAbsNationalReport
{
[JsonProperty(Required=Required.Always)]
public EHeader      header               { get; set; }
    public ETerm[]      libraries            { get; set; }

    public lstring      title                { get; set; }

    public lstring      relevantInformation  { get; set; }
    public ELink[]      relevantDocuments    { get; set; }
    public string       notes                { get; set; }

public ETerm        government           { get; set; }
    public EReference   contact              { get; set; }

    public Response     question3            { get; set; }
    public Response     question4            { get; set; }
    public Response     question5            { get; set; }
    public Response     question6            { get; set; }
    public Response     question7            { get; set; }
    public Response     question8            { get; set; }
    public Response     question9            { get; set; }
    public Response     question10           { get; set; }
    public Response     question11           { get; set; }
    public Response     question12           { get; set; }
    public Response     question13           { get; set; }
    public Response     question14           { get; set; }
    public Response     question15           { get; set; }
    public Q16Type      question16           { get; set; }
    public Response     question17           { get; set; }
    public Q18Type      question18           { get; set; }
    public Response     question19           { get; set; }
    public Response     question20           { get; set; }
    public Response     question21           { get; set; }
    public Response     question22           { get; set; }
    public Response     question23           { get; set; }
    public Q24Type      question24           { get; set; }
    public Q25_26Type   question25           { get; set; }
    public Q25_26Type   question26           { get; set; }
    public Q27Type      question27           { get; set; }
    public Response     question28           { get; set; }
    public Response     question29           { get; set; }
    public Response     question30           { get; set; }
    public Response     question31           { get; set; }
    public Response     question32           { get; set; }
    public Q33Type      question33           { get; set; }
    public Response     question34           { get; set; }
    public Q35Type      question35           { get; set; }
    public Response     question36           { get; set; }
    public Response     question37           { get; set; }
    public Q38Type      question38           { get; set; }
    public Response     question39           { get; set; }
    public Response     question40           { get; set; }
    public Response     question41           { get; set; }
    public Q42Type      question42           { get; set; }
    public Response     question43           { get; set; }
    public Response     question44           { get; set; }
    public Response     question45           { get; set; }
    public Response     question46           { get; set; }
    public Response     question47           { get; set; }
    public Q48Type      question48           { get; set; }
    public Response     question49           { get; set; }
    public Response     question50           { get; set; }
    public Response     question51           { get; set; }
    public Response     question52           { get; set; }
    public Response     question53           { get; set; }
    public Q24Type      question54           { get; set; }
    public Q24Type      question55           { get; set; }
    public Response     question56           { get; set; }
    public Response     question57           { get; set; }
    public Response     question58           { get; set; }
    public Response     question59           { get; set; }
    public Response     question60           { get; set; }
    public Response     question61           { get; set; }
    public Q62Type      question62           { get; set; }
    public Q63Type      question63           { get; set; }
    public Response     question64           { get; set; }
    public lstring      question65           { get; set; }
    public lstring      question66           { get; set; }
    public TextAndLink  question63new   { get; set; }
    public TextAndLink  question64new   { get; set; }
}

//============================================================
//
//
//============================================================
public class Response
{
    public bool     answer                            { get; set; }
    public bool     notApplicable                     { get; set; }
                                                        
    public lstring  furtherInfo                       { get; set; }
    public lstring  challengesInfo                    { get; set; }
    public lstring  additionalInfo                    { get; set; }

    public EDocumentReference[] documentReferenceIDs  { get; set; }
    public ELink[]  relevantDocuments                 { get; set; }
}

//============================================================
//
//
//============================================================
public class TextAndLink
{
    public lstring  relevantInformation               { get; set; }
    public ELink[]  relevantDocuments                 { get; set; }
}

//============================================================
//
//
//============================================================
public class EDocumentReference
{
    public string	identifier {get; set;}
}

//============================================================
//
//
//============================================================
public class Q16Type : Response
{
    public int      permitsOnAbsCh { get; set; }
}

//============================================================
//
//
//============================================================
public class Q18Type : Response
{
    public Q18SubType geneticResources { get; set; } 
    public Q18SubType tk               { get; set; } 
}

//============================================================
//
//
//============================================================
public class Q18SubType
{
    public bool    answer          { get; set; }
    public bool    monetary        { get; set; } 
    public bool    nonMonetary     { get; set; } 
    public lstring monetaryInfo    { get; set; } 
    public lstring nonMonetaryInfo { get; set; } 
}

//============================================================
//
//
//============================================================
public class Q24Type : Response
{
    public Response   violation { get; set; }
    public Q24SubType measures  { get; set; }
}

//============================================================
//
//
//============================================================
public class Q24SubType : Response
{
    public lstring complianceInfo { get; set; }
}

//============================================================
//
//
//============================================================
public class Q25_26Type : Response
{
    public Response violation   { get; set; }
    public bool     hasMeasures { get; set; }
}

//============================================================
//
//
//============================================================
public class Q27Type : Response
{
    public Q27SubType cpc               { get; set; }
    public int        cpcsOnAbsChCount  { get; set; }
}

//============================================================
//
//
//============================================================
public class Q27SubType : Response
{
    public string   option { get; set; }
}

//============================================================
//
//
//============================================================
public class Q33Type : Response
{
    public Response justice    { get; set; }
    public Response mechanisms { get; set; }
}

//============================================================
//
//
//============================================================
public class Q35Type : Response
{
    public Response research    { get; set; }
    public Response emergencies { get; set; }
    public Response access      { get; set; }
    public Response importance  { get; set; }
}

//============================================================
//
//
//============================================================
public class Q38Type : Response
{
    public Response law      { get; set; }
    public Response measures { get; set; }
    public Response pic      { get; set; }
}

//============================================================
//
//
//============================================================
public class Q42Type : Response
{
    public Response community { get; set; }
    public Response mat       { get; set; }
    public Response mcc       { get; set; }
}

//============================================================
//
//
//============================================================
public class Q48Type : Response
{ 
    public lstring  ilcInfo { get; set; }

}

//============================================================
//
//
//============================================================
public class Q62Type : Response
{
    public Response   donor     { get; set; }
    public Q62SubType recipient { get; set; }
    public bool       no        { get; set; } 
}

//============================================================
//
//
//============================================================
public class Q62SubType
{
    public bool    answer                { get; set; }
    public bool    parties               { get; set; }
    public lstring partiesInfo           { get; set; }
    public bool    financialInstitutions { get; set; }
    public bool    gef                   { get; set; }
    public bool    npImplementationFund  { get; set; }
    public bool    otherSources          { get; set; }
    public lstring otherSourcesInfo      { get; set; }
}

//============================================================
//
//
//============================================================
public class Q63Type : Response
{
    public string   numberOfStaff { get; set; }
}