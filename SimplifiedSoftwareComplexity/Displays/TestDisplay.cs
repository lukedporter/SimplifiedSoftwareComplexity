using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;
using SimplifiedSoftwareComplexity.Services;

namespace SimplifiedSoftwareComplexity.Display
{
    public class TestDisplay : IDisplay
    {
        private readonly TestService _testService;
        public HttpResponseMessage Response { get; set; }
        public bool responseExists = false;
        public string TestString { get; set; }
        public bool testStringExists = false;

        public HttpResponseMessage GetHTTPResponse()
        {
            //HttpResponseMessage response = _testService.HttpClientGet();
            //return response;
            return new HttpResponseMessage();
        }
    }
}
