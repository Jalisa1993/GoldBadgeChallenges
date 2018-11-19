using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Outings
    {
        public string OutingType { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime OutingDate { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal EventCost { get; set; }

        public Outings(string outingType, int numberOfPeople, DateTime outingDate, decimal costPerPerson, decimal eventCost)
        {
            OutingType = outingType;
            NumberOfPeople = numberOfPeople;
            OutingDate = outingDate;
            CostPerPerson = costPerPerson;
            EventCost = eventCost;
        }
        public Outings()
        {

        }
    }
}
