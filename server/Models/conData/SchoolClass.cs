using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaApp.Models.ConData
{
  [Table("SchoolClasses", Schema = "dbo")]
  public partial class SchoolClass
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID
    {
      get;
      set;
    }

    public IEnumerable<Student> Students { get; set; }
    public string ClassName
    {
      get;
      set;
    }
  }
}
