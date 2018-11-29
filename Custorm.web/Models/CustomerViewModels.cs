using System;
using System.Collections.Generic;
using System.Text;

namespace Custorm.web
{
    public class CustomerViewModels: BaseDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool? Sex { get; set; }
        public string Telephone { get; set; }
        public string WeiChat { get; set; }
        public string QQ { get; set; }



    }
}
