namespace PropertyTypes
{
    public class Housing
    {
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public string Builder { get; set; }

        public Housing()
        {
        }

        public Housing(string address, int yearbuilt, string builder)
        {
            Address = address;
            YearBuilt = yearbuilt;
            Builder = builder;
        }

        public virtual decimal yearlyRentalIncome()
        {
            return 12000m;
        }

        public virtual string GetDisplayText()
        {
            return Address;
        }
    }
}
