using System;
using System.Collections.Generic;

namespace RoutesTourists;

public partial class User
{
    public string IdUser { get; set; } = null!;

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public int? Mark { get; set; }

    public string Mail { get; set; } = null!;

    public string IdAccount { get; set; } = null!;

    public virtual Account IdAccountNavigation { get; set; } = null!;
}
