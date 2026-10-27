using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsStudy
{
    class HashtableCollection
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();

            ht.Add("empName", "Kiran Khadd");
            ht.Add("empCode", "1301");
            ht.Add("department", "Delivery");
            ht.Add("empPosition", "Sr. Developer");
            ht.Add("empMail", "kirankhadd@xyz.com");

            foreach(var key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }

            Console.ReadLine();
        }
    }
}
