using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceMVC.Data;

public partial class HangHoa
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaHh { get; set; }
    [DisplayName("Tên hàng hóa")]
    public string TenHh { get; set; } = null!;
    [DisplayName("Tên Alias")]
    public string? TenAlias { get; set; }
    [DisplayName("Mã Loại")]
    public int MaLoai { get; set; }
    [DisplayName("Mô tả đơn vị")]
    public string? MoTaDonVi { get; set; }
    [DisplayName("Đơn giá")]
    public double? DonGia { get; set; }
    [DisplayName("Hình")]
    public string? Hinh { get; set; }
    [DisplayName("Ngày sản xuất")]
    public DateTime NgaySx { get; set; }
    [DisplayName("Giảm giá")]
    public double GiamGia { get; set; }
    [DisplayName("Số lần xem")]
    public int SoLanXem { get; set; }
    [DisplayName("Mô tả")]
    public string? MoTa { get; set; }
    [DisplayName("Mã nhà cung cấp")]
    public string MaNcc { get; set; } = null!;

    public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

    public virtual Loai MaLoaiNavigation { get; set; } = null!;

    public virtual NhaCungCap MaNccNavigation { get; set; } = null!;

    public virtual ICollection<YeuThich> YeuThiches { get; set; } = new List<YeuThich>();
}
