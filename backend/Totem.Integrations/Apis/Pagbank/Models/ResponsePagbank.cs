namespace Totem.Integrations.Apis.Pagbank.Models
{
    public class ResponsePagbank
    {
        public string id { get; set; }
        public string reference_id { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public string description { get; set; }
        public Amount amount { get; set; }
        public Payment_Response payment_response { get; set; }
        public Payment_Method payment_method { get; set; }
        public object[] notification_urls { get; set; }
        public Link[] links { get; set; }

        public class Amount
        {
            public int value { get; set; }
            public string currency { get; set; }
            public Summary summary { get; set; }
        }

        public class Summary
        {
            public int total { get; set; }
            public int paid { get; set; }
            public int refunded { get; set; }
        }

        public class Payment_Response
        {
            public string code { get; set; }
            public string message { get; set; }
            public string reference { get; set; }
        }

        public class Payment_Method
        {
            public string type { get; set; }
            public int installments { get; set; }
            public bool capture { get; set; }
            public DateTime capture_before { get; set; }
            public Card card { get; set; }
            public string soft_descriptor { get; set; }
        }

        public class Card
        {
            public string brand { get; set; }
            public string first_digits { get; set; }
            public string last_digits { get; set; }
            public string exp_month { get; set; }
            public string exp_year { get; set; }
            public Holder holder { get; set; }
        }

        public class Holder
        {
            public string name { get; set; }
        }

        public class Link
        {
            public string rel { get; set; }
            public string href { get; set; }
            public string media { get; set; }
            public string type { get; set; }
        }
    }
}
