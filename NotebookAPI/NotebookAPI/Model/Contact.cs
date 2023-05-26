namespace NotebookAPI.Model;

public class Contact : BaseEntity
{
    public string Value { get; set; }

    public int? PersonId { get; set; }
    public Person Person { get; set; }

    public int? ContactTypeId { get; set; }
    public ContactType ContactType { get; set; }

}