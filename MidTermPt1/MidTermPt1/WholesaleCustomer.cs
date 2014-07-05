namespace MidTermPt1
{
    class WholesaleCustomer : Customer
    {
        public string Company { get; set; }

        public WholesaleCustomer()
        {
        }

        public WholesaleCustomer(string firstName, string lastName, string email, string company)
            : base (firstName, lastName, email)
        {
            Company = company;
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " (" + Company + ")";
        }
    }
}
