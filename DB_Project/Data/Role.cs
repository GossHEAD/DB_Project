using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project.Data
{
    public class Role
    {
        [DisplayName("Role_ID")]
        public int RoleId { get; internal set; }

        [DisplayName("Название")]
        public string Name { get; internal set; }
        
       
    }
}
