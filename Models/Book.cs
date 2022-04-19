using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHtruyentranh.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Tên Truyện ")]
        public string TenTruyen { get; set; }
        [Display(Name = "Ngày Bán")]
        [DataType(DataType.Date)]
        public DateTime NgayBan { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Thể Loại")]

        public string TheLoai { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Giá")]
        public decimal Gia { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        [Display(Name = "Tác Giả")]
        public string NoiDung { get; set; }  


    }
}
