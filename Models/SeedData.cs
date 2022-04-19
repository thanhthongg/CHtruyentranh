using Microsoft.Extensions.DependencyInjection;
using CHtruyentranh.Data;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CHtruyentranh.Models;

namespace MVCBooks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CHtruyentranhContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<CHtruyentranhContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Book.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.Book.AddRange(
                new Book
                {
                    TenTruyen = "Atomic Habits",
                    NgayBan = DateTime.Parse("2018-10-16"),
                    TheLoai = "Self-Help",
                    Gia = 11.98M
                },
                new Book
                {
                    TenTruyen = "Dark Roads",
                    NgayBan = DateTime.Parse("2021-8-3"),
                    TheLoai = "Novel",
                    Gia = 18.59M
                }
 );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}