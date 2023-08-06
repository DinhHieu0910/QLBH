using Abp.Application.Services.Dto;

namespace QuanLyBanHang.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

