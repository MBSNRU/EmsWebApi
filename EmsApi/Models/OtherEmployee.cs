using System;
using System.Collections.Generic;

namespace EmsApi.Models;

public partial class OtherEmployee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Adddress { get; set; }

    public int? Salary { get; set; }

    public int? DepartmentId { get; set; }

    public virtual OtherDepartment? Department { get; set; }
}
