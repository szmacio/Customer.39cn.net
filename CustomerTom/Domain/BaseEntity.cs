using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManager.Core.Domain
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatDate { get; set; }
        public int BDel { get; set; }
    }
}
