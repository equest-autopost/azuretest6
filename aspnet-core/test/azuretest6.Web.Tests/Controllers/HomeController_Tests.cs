using System.Threading.Tasks;
using azuretest6.Models.TokenAuth;
using azuretest6.Web.Controllers;
using Shouldly;
using Xunit;

namespace azuretest6.Web.Tests.Controllers
{
    public class HomeController_Tests: azuretest6WebTestBase
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