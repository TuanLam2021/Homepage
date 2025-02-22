﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homepage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.ANHBIAs = new HashSet<ANHBIA>();
            this.BANGGIAs = new HashSet<BANGGIA>();
            this.CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            this.FEEDBACKs = new HashSet<FEEDBACK>();
        }

        [Display(Name = "Mã sách")]
        public int ID_SACH { get; set; }

        [Display(Name = "Tên sách")]
        public string TEN_SACH { get; set; }

        [Display(Name = "Loại bìa")]
        public string LOAI_BIA { get; set; }

        [Display(Name = "Ngày xuất bản")]
        public string NGAY_XUATBAN { get; set; }

        [Display(Name = "Số lượng tồn")]
        public Nullable<short> SOLUONG_TON { get; set; }

        [Display(Name = "Số trang")]
        public Nullable<short> SO_TRANG { get; set; }

        [Display(Name = "Kích thước")]
        public string KICH_THUOC { get; set; }

        [Display(Name = "Mô tả")]
        public string MOTA { get; set; }

        [Display(Name = "Mã NXB")]
        public Nullable<int> ID_NXB { get; set; }

        [Display(Name = "Mã tác giả")]
        public Nullable<int> ID_TACGIA { get; set; }

        [Display(Name = "Mã nhà cung cấp")]
        public Nullable<int> ID_NCC { get; set; }

        [Display(Name = "Mã thể loại")]
        public Nullable<int> ID_THELOAI { get; set; }

        [Display(Name = "Khối lượng")]
        public Nullable<double> KHOILUONG { get; set; }

        [Display(Name = "Giá bìa")]
        public Nullable<double> GIA_BIA { get; set; }

        [Display(Name = "Giá bán")]
        public Nullable<double> GIA_BAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANHBIA> ANHBIAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGGIA> BANGGIAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FEEDBACK> FEEDBACKs { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
        public virtual TACGIA TACGIA { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}
