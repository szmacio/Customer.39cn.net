using AutoMapper;
using CustomerManager.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custorm.web.Models
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Customer, CustomerViewModels>();
        }
    
    }
}