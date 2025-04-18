﻿using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class FoodCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
}
