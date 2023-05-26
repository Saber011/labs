using System.ComponentModel.DataAnnotations.Schema;

namespace NotebookAPI.Model;

public class BaseEntity
{
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }
}