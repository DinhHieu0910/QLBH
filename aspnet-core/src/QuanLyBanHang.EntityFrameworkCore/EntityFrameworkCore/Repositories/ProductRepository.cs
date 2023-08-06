using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.EntityFrameworkCore.Repositories
{
    public class ProductRepository : QuanLyBanHangRepositoryBase<Product>
    {
        public ProductRepository(IDbContextProvider<QuanLyBanHangDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
