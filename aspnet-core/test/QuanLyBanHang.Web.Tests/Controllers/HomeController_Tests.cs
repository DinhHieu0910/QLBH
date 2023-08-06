using System.Threading.Tasks;
using QuanLyBanHang.Models.TokenAuth;
using QuanLyBanHang.Web.Controllers;
using Shouldly;
using Xunit;

namespace QuanLyBanHang.Web.Tests.Controllers
{
    public class HomeController_Tests: QuanLyBanHangWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}