using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class UserAccount
{
    public string DisplayName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Type { get; set; }
}
