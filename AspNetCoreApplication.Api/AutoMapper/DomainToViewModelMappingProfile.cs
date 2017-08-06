using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        : this("Profile")
        {

        }

        protected DomainToViewModelMappingProfile(string profileName)
         : base(profileName)
        {
            
        }
    }
}
