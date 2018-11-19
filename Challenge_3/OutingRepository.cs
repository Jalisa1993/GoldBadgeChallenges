using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        List<Outings> _outingsListing = new List<Outings>();

        public int total { get; private set; }

        void CastOutingsToList(Outings latestOutings)
        {
            _outingsListing.Add(latestOutings);
        }
         public List<Outings> SeeOutingsList()
        {
            return _outingsListing;
        }
        public decimal SumOfOutings()
        {
            decimal sum = 0;
            foreach (Outings outings in _outingsListing)
            {
                total += outings.EventCost;
            }
            return total;
        }
        public decimal ExpensesPerEvent(string type)
        {
            decimal typesSum = 0;
            foreach (Outings o in _outingsListing)
            {
                if (type == o.OutingType)
                {
                    typesSum += o.EventCost;
                }
            }
            return typesSum;
        }
    }
}
