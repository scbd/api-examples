public class EContact :  EContactBase
{
  [JsonProperty(Required=Required.Always)]
  public EHeader	header					{ get; set; }

      public lstring  relevantInformation         { get; set; }
      public ELink[]  relevantDocuments           { get; set; }
      public string   notes                       { get; set; }

      public string   type                        { get; set; } // "organization" || "person" -> default "person"
  [Term("countries")]
      public EReference government                { get; set; }
      public EReference contactOrganization       { get; set; }

      /*
       * When type == person
       * 	firstName & lastName are madatory
       * 	
       * When type == organization
       *	organization is mandatory
       */
}
