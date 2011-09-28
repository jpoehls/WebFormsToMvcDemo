using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTFWebFormsToMvc.Data
{
    public class StockOption
    {
        public static StockOption Available = new StockOption("Available");
        public static StockOption Backordered = new StockOption("Backordered");

        private static int LastId;

        private StockOption(string name)
        {
            Id = ++LastId;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public static IEnumerable<StockOption> GetAll()
        {
            return new[] { Available, Backordered };
        }

        public static StockOption GetById(int id)
        {
            if (id == Available.Id) return Available;
            if (id == Backordered.Id) return Backordered;
            return null;
        }
    }
}
