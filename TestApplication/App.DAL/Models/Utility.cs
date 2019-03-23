using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Models
{
    public class Utility
    {
        // based on the action to be performed work on the details.
        public bool AllinOneUserActionMethod(User data, int action) // as per given proc only one method should be allowed to handle all the changes
        {
            switch (action)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
