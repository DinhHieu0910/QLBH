using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QuanLyBanHang.Authorization.Roles;
using QuanLyBanHang.Authorization.Users;
using QuanLyBanHang.MultiTenancy;
using Abp.Auditing;

namespace QuanLyBanHang.EntityFrameworkCore
{
    public class QuanLyBanHangDbContext : AbpZeroDbContext<Tenant, Role, User, QuanLyBanHangDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QuanLyBanHangDbContext(DbContextOptions<QuanLyBanHangDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Use fluent API to configure a model
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region audit log
            modelBuilder.Entity<AuditLog>()
                .Property(e => e.ExceptionMessage)
                .HasColumnType("nvarchar(max)");
            #endregion

            //sản phẩm
            modelBuilder.Entity<Product>().HasKey(entity => entity.Id);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("AsProduct");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .ValueGeneratedOnAdd()
                    .IsRequired();

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasColumnType("nvarchar(500)")
                    .IsRequired();

                entity.Property(e => e.Quantity)
                    .HasColumnName("Quantity")
                    .IsRequired();
            });
        }
    }
}
