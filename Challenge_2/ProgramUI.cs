using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ProgramUI
    {
        ClaimRepository _claimRepo = new ClaimRepository();

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. See all claims" +
                    "\n2. Resolve a claim " +
                    "\n3. Enter a new claim" +
                    "\n4. Exit");
                int response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        SeeAllClaims();
                        break;
                    case 2:
                        ResolveClaim();
                        break;
                    case 3:
                        CreateClaimItem();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        Console.ReadLine();
                        break;
                }

            }

        }

        private void CreateClaimItem()
        {
            Claim newClaim = new Claim();
            Console.WriteLine(" Enter claim ID:");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter claim type:");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter claim description:");
            newClaim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Enter claim amount?");
            newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of incident:");
            newClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of claim");
            newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());
            int days = (newClaim.DateOfClaim - newClaim.DateOfIncident).Days;
            if (days >= 0 && days <= 30)
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }
            _claimRepo.AddClaimQueue(newClaim);
        }

        private void SeeAllClaims()
        {
            Console.WriteLine("ClaimID" + "\t Type" + "\tDescription" + "\tAmount" + "\tDateOfIncident" + "\t\t\tDateOfClaim" + "\t\t\tIsValid");
            foreach (Claim claims in _claimRepo.GetClaimQueue())
            {
                Console.WriteLine($"{claims.ClaimID}" +
                        $"\t{claims.ClaimType}" +
                        $"\t{claims.ClaimDescription}" +
                        $"\t\t{claims.ClaimAmount}" +
                        $"\t{claims.DateOfIncident.ToShortDateString()}" +
                        $"\t{claims.DateOfClaim.ToShortDateString()}" +
                        $"\t{claims.IsValid}");
            }
            Console.ReadLine();
        }
        private void ResolveClaim()
        {
            Console.WriteLine("Do you want to resolve your claim?  (y/n)");
            string resolvingClaim = Console.ReadLine();
            _claimRepo.RemoveClaim();
            if (resolvingClaim == "y")
            {
                _claimRepo.RemoveClaim();
            }
             else
            {
                _claimRepo.GetClaimQueue();
            }

        }
    }
}
