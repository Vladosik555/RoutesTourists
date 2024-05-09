using System;
using System.Collections.Generic;

namespace RoutesTourists;

public partial class Account
{
    public string Id { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual User? User { get; set; }
}
