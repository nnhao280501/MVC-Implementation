//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebXemPhim.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class DSPhimBo
    {
        public DSPhimBo()
        {
            this.Banners = new HashSet<Banner>();
            this.CTTapPhims = new HashSet<CTTapPhim>();
            this.TaiKhoans = new HashSet<TaiKhoan>();
            this.TaiKhoans1 = new HashSet<TaiKhoan>();
        }
    
        public int ID { get; set; }
        public string TenPhim { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> NamPhatHanh { get; set; }
        public Nullable<int> IDTheLoai { get; set; }
        public string ThoiLuong { get; set; }
        public string Img { get; set; }
        public Nullable<int> MaQG { get; set; }
        public Nullable<int> LuotXem { get; set; }
    
        public virtual ICollection<Banner> Banners { get; set; }
        public virtual ICollection<CTTapPhim> CTTapPhims { get; set; }
        public virtual Nam Nam { get; set; }
        public virtual QuocGia QuocGia { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans1 { get; set; }
    }
}
