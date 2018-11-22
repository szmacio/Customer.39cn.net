using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManager.Core.Domain
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool? Sex { get; set; }
        public string Telephone { get; set; }
        public string WeiChat { get; set; }
        public string QQ { get; set; }
        public string Blog { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Adress { get; set; }
        //Company or person
        public int Type{ get; set; }

        public string Source { get; set; }

        public string Email { get; set; }

        public string Remark { get; set; }

        public string CreatUser { get; set; }

        public string UpdateUser { get; set; }

        public string KeyWord { get; set; }

        public string TelPhone { get; set; }

        public string Birthday { get; set; }

        public string URL { get; set; }


    }
}
