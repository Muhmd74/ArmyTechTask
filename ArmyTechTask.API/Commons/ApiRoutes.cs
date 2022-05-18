namespace ArmyTechTask.API.Commons
{
    internal class ApiRoutes
    {
        public const string RootUrl = "/api/";

        public static class InvoiceHeaders
        {

            public const string GetAll = InvoiceHeaderBaseRoute;
            public const string Get = $"{InvoiceHeaderBaseRoute}{{id}}";

            private const string InvoiceHeaderBaseRoute = RootUrl + "invoiceHeader/";

        }

        public static class Cashiers
        {
            public const string Create = CashierBaseRoute;
            public const string Update = $"{CashierBaseRoute}{{id}}";
            public const string GetAll = CashierBaseRoute;
            public const string Get = $"{CashierBaseRoute}{{id}}";
            public const string BranchLookup = RootUrl + "branches/lookups";

            private const string CashierBaseRoute = RootUrl + "cashiers/";

        }
    }
}
