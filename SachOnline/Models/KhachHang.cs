﻿namespace SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            GioHangs = new HashSet<GioHang>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Display(Name = "Số điện thoại")]
        [StringLength(10)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Số điện thoại: Bạn nhập không đúng định dạng. Phải có 10 số và là chữ số!")]
        [Required(ErrorMessage = "Số điện thoại: Trường này không được để trống")]
        public string SDT { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên khách hàng")]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string TenKH { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$",
                   ErrorMessage = "Email: Chứa các ký tự chữ cái, chữ số, dấu chấm, gạch dưới.Ký tự @. Nhóm ký tự trước @ có 6 - 32 ký tự.Nhóm ký tự sau @ là domain một hoặc nhiều cấp")]
        [Required(ErrorMessage = "Email:Trường này không được để trống")]
        public string Email { get; set; }


        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu: Trường này không được để trống")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$",
                    ErrorMessage = "Mật khẩu: Tối thiểu tám ký tự, ít nhất một chữ cái và một số!")]
        public string MatKhau { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ: Trường này không được để trống")]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
