using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimRepository
    {
        Queue<Claim> _claimQueue = new Queue<Claim>();

        public void AddClaimQueue(Claim claim)
        {
            _claimQueue.Enqueue(claim);
        }
        public Queue<Claim> GetClaimQueue()
        {
            return _claimQueue;
        }
       
        public Queue<Claim> RemoveClaim()
        {
            _claimQueue.Dequeue();
            return _claimQueue;
        }
    }
}
