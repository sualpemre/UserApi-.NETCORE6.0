using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User.Entities;

public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    [StringLength(50)]
    public string Surname { get; set; }
    [StringLength(50)]
    public string Email { get; set; }
    [StringLength(50)]
    public string City { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime Created { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime Updated { get; set; }
}