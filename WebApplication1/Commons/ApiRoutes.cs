namespace WebApplication1.Commons
{
    internal class ApiRoutes
    {
        public const string RootUrl = "/api/";

        public static class InvoiceHeaders
        {

            public const string GetAll = InvoiceHeaderBaseRoute;

            private const string InvoiceHeaderBaseRoute = RootUrl + "InvoiceHeader/";

        }
    }
}
