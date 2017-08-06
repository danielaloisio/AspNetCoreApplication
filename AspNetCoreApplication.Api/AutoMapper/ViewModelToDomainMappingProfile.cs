using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        : this("Profile")
        {

        }

        protected ViewModelToDomainMappingProfile(string profileName)
         : base(profileName)
        {
            
        }
    }
}
