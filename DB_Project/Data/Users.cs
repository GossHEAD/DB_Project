using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project.Data
{
    internal class Users
    {
        [DisplayName("User_ID")]
        public int UserId { get; internal set; }

        [DisplayName("Имя")]
        public string Name { get; internal set; }
        [DisplayName("Количество")]
        public int Count { get; internal set; }
        [DisplayName("Категория")]
        public string Category { get; internal set; }
    }
}
