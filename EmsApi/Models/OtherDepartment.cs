using System;
using System.Collections.Generic;

namespace EmsApi.Models;

public partial class OtherDepartment
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<OtherEmployee> OtherEmployees { get; set; } = new List<OtherEmployee>();
}
