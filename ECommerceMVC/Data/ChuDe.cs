using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class ChuDe
{
    public int MaCd { get; set; }

    public virtual ICollection<GopY> Gopies { get; set; } = new List<GopY>();
}
