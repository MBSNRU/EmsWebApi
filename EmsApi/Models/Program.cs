using System;
using System.Collections.Generic;

namespace EmsApi.Models;

public partial class Program
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public int? Duration { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
