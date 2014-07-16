using System.Collections.Generic;
using System.Linq;
using PropertyTypes;

namespace RentalPropertyManager
{
    class TheProperties
    {
        private List<Housing> properties = new List<Housing>();

        public delegate void PropertiesHandler(TheProperties p);

        public event PropertiesHandler Changed;

        //protected virtual void OnChanged(TheProperties p)
        //{
        //    if (Changed != null)
        //        Changed(p);
        //}

        public int Count
        {
            get { return properties.Count(); }
        }

        public Housing this[int i]
        {
            get { return properties[i]; }
            set { properties[i] = value; Changed(this); }
        }

        public void Add(Housing house)
        {
            properties.Add(house);
            Changed(this);
        }

        public void Remove(Housing house)
        {
            properties.Remove(house);
            Changed(this);
        }

        public static TheProperties operator +(TheProperties p, Housing house)
        {
            if (house != null)
                p.Add(house);
            return p;
        }

        public static TheProperties operator -(TheProperties p, Housing house)
        {
            if (house != null)
                p.Remove(house);
            return p;
        }
    }
}
