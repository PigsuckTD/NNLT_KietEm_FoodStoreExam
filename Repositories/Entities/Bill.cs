using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Bill
{
    public int Id { get; set; }

    public DateOnly DateCheckIn { get; set; }

    public DateOnly? DateCheckOut { get; set; }

    public int IdTable { get; set; }

    public int Status { get; set; }

    public virtual ICollection<BillInfo> BillInfos { get; set; } = new List<BillInfo>();

    public virtual TableFood IdTableNavigation { get; set; } = null!;
}
