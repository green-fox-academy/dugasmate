using GuardiansVol2;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Guardians.IntegrationTests
{
    public class UnitTest1
    {
        private HttpClient Client;
        private TestServer Server;

        public UnitTest1()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async Task GivenResponseTest()
        {
            //act
            var response = await Client.GetAsync("groot?message=valami");
            //assertélékjklklhlhljfdfh
        }
    }
}
