using GuardiansofTheGalaxy;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using System.Net;

namespace GuardianTester
{
    public class GuardianTest1
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTest1()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
