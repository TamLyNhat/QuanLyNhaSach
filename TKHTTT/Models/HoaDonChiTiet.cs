//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TKHTTT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonChiTiet
    {
        public string MaSach { get; set; }
        public string MaHD { get; set; }
        public Nullable<float> DonGia { get; set; }
        public Nullable<decimal> SoLuong { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
