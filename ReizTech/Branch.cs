using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech
{
    class Branch
    {
        private List<Branch> branches;
        public Branch()
        {
            branches = new List<Branch>();
        }
        public List<Branch> GetBranches()
        {
            return branches;
        }
        public void AddBranch(Branch newBranch)
        {
            branches.Add(newBranch);
        }
    }
}
