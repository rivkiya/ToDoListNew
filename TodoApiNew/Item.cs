using System;
using System.Collections.Generic;

namespace TodoApiNew;

public partial class Item
{
    public int id { get; set; }

    public string? name { get; set; }

    public bool? iscomplited { get; set; }
}
