using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using QuanLyBanHang.Authorization.Users;
using System;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class Product : Entity<int>, IFullAudited<User>
    {
        public Product()
        {
            CreationTime = DateTime.Now;
        }

        public string Name { get; set; }
        public int Quantity { get; set; }

        public User CreatorUser { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public User LastModifierUser { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User DeleterUser { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
