using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.UI;
using QuanLyBanHang.Constants;
using QuanLyBanHang.Dto;
using QuanLyBanHang.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyBanHang
{
    public class ProductAppService : QuanLyBanHangAppServiceBase
    {
        private readonly ProductRepository _productRepo;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public ProductAppService(ProductRepository productRepo, IUnitOfWorkManager unitOfWorkManager)
        {
            _productRepo = productRepo;
            _unitOfWorkManager=unitOfWorkManager;
        }

        public async Task<List<Product>> GetProduct()
        {
            return _productRepo.GetDbQueryTable().Where(o => !o.IsDeleted).ToList();
        }

        public async Task CreateProduct(ProductDto input)
        {
            var unitOfWork = _unitOfWorkManager.Begin();
            _productRepo.Insert(new Product
            {
                Name = input.Name,
                Quantity = input.Quantity,
            });

            await unitOfWork.CompleteAsync();
        }

        public async Task<Product> GetById(int id)
        {
            var product = _productRepo.FirstOrDefault(o => o.Id == id && !o.IsDeleted);
            if (product == null)
            {
                throw new UserFriendlyException("Không tìm thấy sản phẩm");
            }
            return product;
        }

        public async Task UpdateProduct(ProductDto input)
        {
            var unitOfWork = _unitOfWorkManager.Begin();
            var product = _productRepo.FirstOrDefault(o => o.Id == input.Id && !o.IsDeleted);
            if (product == null)
            {
                throw new UserFriendlyException("Không tìm thấy sản phẩm");
            }
            product.Name = input.Name;
            product.Quantity = input.Quantity;

            await unitOfWork.CompleteAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var unitOfWork = _unitOfWorkManager.Begin();
            var product = _productRepo.FirstOrDefault(o => o.Id == id && !o.IsDeleted);
            if (product == null)
            {
                throw new UserFriendlyException("Không tìm thấy sản phẩm");
            }
            product.IsDeleted = YesNo.Yes;

            await unitOfWork.CompleteAsync();
        }
    }
}
