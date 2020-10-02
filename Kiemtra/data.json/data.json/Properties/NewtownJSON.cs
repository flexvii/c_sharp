using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace data.json.Properties
{
    class NewtownJSON
    {
        public List<Employee_list> show { get; set; }
    }

    class Employee_list
    {
        public string name { get; set; }
        public string role { get; set; }
        public int birthday { get; set; }
    }
 


}
