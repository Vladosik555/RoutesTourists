using System;
using System.Collections.Generic;

namespace RoutesTourists;

public partial class Route
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Duration { get; set; } = null!;

    public int Budget { get; set; }

    public string? Seasonality { get; set; }

    public byte[]? Photo { get; set; }

    public int? AverageMark { get; set; }

    public string? Attractions { get; set; }

    public string? Hotels { get; set; }

    public string? Flight { get; set; }
}
