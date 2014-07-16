namespace PropertyTypes
{
    public class SingleFamily : Housing
    {
        public int SquareFeet { get; set; }
        public bool HasGarage { get; set; }
        public decimal Rent { get; set; }

        public SingleFamily()
            : base()
        {
        }

        public SingleFamily(string address, int yearBuilt, string builder, int squareFeet, bool hasGarage, decimal rent)
            : base(address, yearBuilt, builder)
        {
            SquareFeet = squareFeet;
            HasGarage = hasGarage;
            Rent = rent;
        }

        public override decimal yearlyRentalIncome()
        {
            return Rent * 12;
        }
    }
}
