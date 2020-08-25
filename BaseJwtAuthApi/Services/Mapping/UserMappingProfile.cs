using AutoMapper;
using EtainTechnicalTest.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtainTechnicalTest.Services.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<RegisterModel, UserModel>().ReverseMap();
        }
    }
}
