using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Models
{
    public class UserTokenDetails
    {
        public long TokenId { get; set; }
        public long UserProfileID { get; set; }
        public string AuthToken { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
