namespace Totem.Domain.Dtos
{
    public class PaymentDto
    {
        public string reference_id { get; set; }
        public string description { get; set; }
        public Amount amount { get; set; }
        public Payment_Method payment_method { get; set; }


        public class Amount
        {
            public int value { get; set; }
            public string currency { get; set; }
        }

        public class Payment_Method
        {
            public string type { get; set; }
            public int installments { get; set; }
            public bool capture { get; set; }
            public Card card { get; set; }
        }

        public class Card
        {
            public string number { get; set; }
            public string exp_month { get; set; }
            public string exp_year { get; set; }
            public string security_code { get; set; }
            public Holder holder { get; set; }
        }

        public class Holder
        {
            public string name { get; set; }
        }
    }
}
