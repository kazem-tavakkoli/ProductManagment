using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ProductManagment.Pages;

public class Index_Tests : ProductManagmentWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
