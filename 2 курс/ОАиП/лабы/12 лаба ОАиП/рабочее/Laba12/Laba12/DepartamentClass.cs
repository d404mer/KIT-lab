using login_system;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    public class DepartamentClass
    {
        public long ID { get; set; }
        public string DepName { get; set; }
        public int UserID { get; set; }

        public List<User> Users { get; set; }

        public DepartamentClass() {
            Users = new List<User>();
        }
    }

    
}
