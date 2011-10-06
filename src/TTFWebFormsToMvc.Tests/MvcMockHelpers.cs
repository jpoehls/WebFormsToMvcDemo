using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;

namespace TTFWebFormsToMvc.Tests
{
    // originally taken from: http://www.hanselman.com/blog/ASPNETMVCSessionAtMix08TDDAndMvcMockHelpers.aspx
    public static class MvcMockHelpers
    {
        public static HttpContextBase FakeHttpContext()
        {
            var context = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            var response = new Mock<HttpResponseBase>();
            var session = new Mock<HttpSessionStateBase>();
            var server = new Mock<HttpServerUtilityBase>();

            context.SetupGet(ctx => ctx.Request).Returns(request.Object);
            context.SetupGet(ctx => ctx.Response).Returns(response.Object);
            context.SetupGet(ctx => ctx.Session).Returns(session.Object);
            context.SetupGet(ctx => ctx.Server).Returns(server.Object);

            return context.Object;
        }

        public static HttpContextBase FakeHttpContext(string url)
        {
            HttpContextBase context = FakeHttpContext();
            context.Request.SetupRequestUrl(url);
            return context;
        }

        public static void SetFakeControllerContext(this Controller controller)
        {
            var httpContext = FakeHttpContext();
            var context = new ControllerContext(new RequestContext(httpContext, new RouteData()), controller);
            controller.ControllerContext = context;
        }

        public static void SetupAsAjaxRequest(this Controller controller)
        {
            var mockRequest = Mock.Get(controller.HttpContext.Request);
            if (mockRequest == null)
                throw new InvalidOperationException("Expected the controller's HttpContext.Request to be a mock. It wasn't.");

            mockRequest.Setup(x => x["X-Requested-With"]).Returns("XMLHttpRequest");
        }

        static string GetUrlFileName(string url)
        {
            if (url.Contains("?"))
                return url.Substring(0, url.IndexOf("?"));
            return url;
        }

        static NameValueCollection GetQueryStringParameters(string url)
        {
            if (url.Contains("?"))
            {
                var parameters = new NameValueCollection();

                string[] parts = url.Split("?".ToCharArray());
                string[] keys = parts[1].Split("&".ToCharArray());

                foreach (string key in keys)
                {
                    string[] part = key.Split("=".ToCharArray());
                    parameters.Add(part[0], part[1]);
                }

                return parameters;
            }
            return null;
        }

        public static void SetHttpMethodResult(this HttpRequestBase request, string httpMethod)
        {
            Mock.Get(request)
                .SetupGet(req => req.HttpMethod)
                .Returns(httpMethod);
        }

        public static void SetupRequestUrl(this HttpRequestBase request, string url)
        {
            if (url == null)
                throw new ArgumentNullException("url");

            if (!url.StartsWith("~/"))
                throw new ArgumentException("Sorry, we expect a virtual url starting with \"~/\".");

            var mock = Mock.Get(request);

            mock.SetupGet(req => req.QueryString)
                .Returns(GetQueryStringParameters(url));
            mock.SetupGet(req => req.AppRelativeCurrentExecutionFilePath)
                .Returns(GetUrlFileName(url));
            mock.SetupGet(req => req.PathInfo)
                .Returns(string.Empty);
        }
    }
}
