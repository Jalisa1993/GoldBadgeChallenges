using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimRepository
    {
        Queue<Claim> _queue = new Queue<Claim>();

        public void AddClaimQueue(Claim claim)
        {
            _queue.Enqueue(claim);
        }
        public Queue<Claim> GetClaimQueue()
        {
            return _queue;
        }
        public Queue<Claim> TakeCareOfNextClaims()
        {
            return _queue;
        }
    }
}
