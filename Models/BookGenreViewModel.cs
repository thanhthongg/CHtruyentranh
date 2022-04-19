using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace CHtruyentranh.Models
{
    public class BookGenreViewModel
    {
        public List<Book>? DanhSachTruyen { get; set; }
        public SelectList? TheLoaiTruyen { get; set; }
        public string? BookGenre { get; set; }
        public string? SearchString { get; set; }
    }
}