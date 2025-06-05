﻿using System;
using System.Collections.Generic;

namespace DATA.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public virtual ICollection<EventUser> EventUsers { get; set; } = new List<EventUser>();
}
