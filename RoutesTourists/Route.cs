﻿using System;
using System.Collections.Generic;

namespace RoutesTourists;

public partial class Route
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Duration { get; set; }

    public int Budget { get; set; }

    public string? Seasonality { get; set; }

    public byte[]? Photo { get; set; }

    public int? AverageMark { get; set; }

    public string? Attractions { get; set; }

    public string? Hotels { get; set; }

    public string? Flight { get; set; }

    public string? Description { get; set; }

    public string? Marks { get; set; }

    public int? Likes { get; set; }

    public int? LikesSelection { get; set; }
}
