using System;
using System.Net.Http;
using System.Threading.Tasks;
using JackWFinlay.Jsonize.Abstractions.Models;
using JackWFinlay.Jsonize.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace JackWFinlay.Jsonize.Test
{
    public class EndToEndAngleSharpNewtonsoftTests : IClassFixture<EndToEndAngleSharpNewtonsoftTestFixture>
    {
        private readonly EndToEndAngleSharpNewtonsoftTestFixture _fixture;
        private readonly ITestOutputHelper _testOutputHelper;

        public EndToEndAngleSharpNewtonsoftTests(EndToEndAngleSharpNewtonsoftTestFixture fixture, ITestOutputHelper testOutputHelper)
        {
            _fixture = fixture;
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task DocoHtmlString_DefaultConfiguration_ProducesValidOutput()
        {
            var jsonize = await _fixture.Jsonizer.ParseToStringAsync(StringResources.DocoHtmlExample);

            Assert.Equal(StringResources.DocoHtmlExampleResult, jsonize);
            
            _testOutputHelper.WriteLine(jsonize);
        }

        [Fact]
        public async Task TestOutput()
        {
            const string html = StringResources.HtmlBodyP;

            var output = await _fixture.Jsonizer.ParseToStringAsync(html);

            Assert.Equal(StringResources.HtmlBodyPResult, output);
            
            _testOutputHelper.WriteLine(output);
        }
    }
}