using System;
using System.Collections.Generic;

namespace EmsApi.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CourseId { get; set; }

    public string? Syllabus { get; set; }

    public virtual Course? Course { get; set; }
}
