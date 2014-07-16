namespace PropertyTypes
{
    public class MultiUnit : Housing
    {
        public int NumUnits { get; set; }
        public decimal PricePerUnit { get; set; }

        public MultiUnit()
            : base()
        {
        }

        public MultiUnit(string address, int yearBuilt, string builder, int numUnits, decimal pricePerUnit)
            : base (address, yearBuilt, builder)
        {
            NumUnits = numUnits;
            PricePerUnit = pricePerUnit;
        }

        public override decimal yearlyRentalIncome()
        {
            return (NumUnits * PricePerUnit) * 12;
        }

        //public override string GetDisplayText()
        //{
        //    return base.GetDisplayText() + " " + NumUnits;
        //}
    }
}
