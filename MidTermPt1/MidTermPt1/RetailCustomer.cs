namespace MidTermPt1
{
    class RetailCustomer : Customer
    {
        public string HomePhone { get; set; }

        public RetailCustomer()
        {
        }

        public RetailCustomer(string firstName, string lastName, string email, string homePhone)
            : base(firstName, lastName, email)
        {
            HomePhone = homePhone;
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " ph:" + HomePhone;
        }
    }
}
