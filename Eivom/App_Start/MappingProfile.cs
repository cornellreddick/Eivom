using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Eivom.Models;
using Eivom.Dtos;

namespace Eivom.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Automapping uses reflection to scan these type and find the properties and
            //maps them base on there name. This is why auto mapper is called a convention
            //base mapping tool. 
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}   
