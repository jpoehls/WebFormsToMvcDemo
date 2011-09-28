using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTFWebFormsToMvc.Data
{
    public class ShippingOption
    {
        public static ShippingOption GiftWrap = new ShippingOption("Gift Wrap");
        public static ShippingOption Overnight = new ShippingOption("Overnight");

        private static int LastId;

        private ShippingOption(string name)
        {
            Id = ++LastId;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public static IEnumerable<ShippingOption> GetAll()
        {
            return new[] { GiftWrap, Overnight };
        }

        public static ShippingOption GetById(int id)
        {
            if (id == GiftWrap.Id) return GiftWrap;
            if (id == Overnight.Id) return Overnight;
            return null;
        }
    }
}
