namespace Sitecore.Foundation.Testing.Specflow.Steps
{
  using Sitecore.Foundation.Testing.Specflow.UtfService;

  public class EditFieldPayload
  {
    public string ItemIdOrPath { get; set; }
    public string FieldName { get; set; }
    public string FieldValue { get; set; }
    public Database Database { get; set; }
  }
}