using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingRepository _outingRepo = new OutingRepository();
        public void RunOutingMenu()
        {
            bool outingMenuIsRunning = true;
            while (outingMenuIsRunning)
            {
                Console.WriteLine(" Choose one of the options below" +
                    "\n1. View outing list." +
                    "\n2. Cast outing to list." +
                    "\n3. View outing expenses" +
                    "\n4. Expenses per event" +
                    "\n5. Exit");

                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        SeeOutingsList();
                        break;
                    case 2:
                        CastOutingToList();
                        break;
                    case 3:
                        ViewOutingExpenses($"Your total sum for this outing will be{_outingRepo.SumOfOutings()}");
                        break;
                    case 4:
                        ExpensesPerEvent();
                        break;
                    case 5:
                        outingMenuIsRunning = false;
                        Console.WriteLine("Thank's for choosing Komodo's Outings! Farewell");
                        Console.ReadLine();
                        break;
                }

            }
        }

        private void ViewOutingExpenses(string v)
        {
            throw new NotImplementedException();
        }

        private void ExpensesPerEvent()
        {
           List<Outings> listOfOutings = _outingRepo.SeeOutingsList();

            Console.WriteLine("Which event are you interested in?");
            string outings = Console.ReadLine();
            decimal sumOfEvent = 0m;

            foreach (Outings o in listOfOutings)
            {
                if (outings == o.OutingType) 
                {
                    sumOfEvent += o.EventCost;
                }
            }
            Console.WriteLine($"The total for your experience will be{sumOfEvent}");
            decimal.Parse(Console.ReadLine());
        }

        private void CastOutingToList()
        {
            Outings latestOuting = new Outings();
            Console.WriteLine("Which Event would you prefer?");
            latestOuting.OutingType = Console.ReadLine();

            Console.WriteLine("What date will your event take place?");
            latestOuting.OutingDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("How many people will be attending this event?");
            latestOuting.NumberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("Price per person");
            latestOuting.CostPerPerson = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Price per event");
            latestOuting.EventCost = decimal.Parse(Console.ReadLine());

            _outingRepo.CastOutingsToList(latestOuting);
        }

        public void SeeOutingsList()
        {
            List<Outings> listOfOutings = _outingRepo.SeeOutingsList();
            foreach (Outings outings in listOfOutings)
                Console.WriteLine($"Select something from the list {outings.OutingDate} {outings.OutingType} {outings.CostPerPerson} {outings.NumberOfPeople} {outings.EventCost}");
            Console.ReadLine();
        }
    }
}
