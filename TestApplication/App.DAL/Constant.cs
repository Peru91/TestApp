using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
    public static class Constant
    {
        public enum Action
        {
            Authenticate=1,
            GenerateToken=2,
            ValidateToken=3,
            KillToken=4,
            All=5,
            One=6,
            Insert=7,
            Update=8
        }
    }
}
