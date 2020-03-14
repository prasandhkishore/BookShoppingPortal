using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShoppingPortal.Entitity
{
    public class Account
    {
       [Key]
       public int UserId { get; set; }
       public string Name { get; set; }
       public string MailId { get; set; }
       public string Password { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }
    }
}
