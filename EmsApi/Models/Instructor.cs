using System;
using System.Collections.Generic;

namespace EmsApi.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Adddress { get; set; }

    public int? Salary { get; set; }

    public string? Specialization { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }
}
