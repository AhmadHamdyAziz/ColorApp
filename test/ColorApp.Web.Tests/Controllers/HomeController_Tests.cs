﻿using System.Threading.Tasks;
using ColorApp.Models.TokenAuth;
using ColorApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace ColorApp.Web.Tests.Controllers
{
    public class HomeController_Tests: ColorAppWebTestBase
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