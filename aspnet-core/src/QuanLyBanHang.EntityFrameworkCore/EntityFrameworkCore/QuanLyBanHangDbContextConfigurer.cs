using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QuanLyBanHang.EntityFrameworkCore
{
    public static class QuanLyBanHangDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QuanLyBanHangDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QuanLyBanHangDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
