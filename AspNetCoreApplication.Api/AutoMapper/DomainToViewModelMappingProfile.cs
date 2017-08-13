using AspNetCoreApplication.Data.Common;
using AspNetCoreApplication.Data.Entities.Product.Model;
using AspNetCoreApplication.Data.Entities.Product.Out;
using AspNetCoreApplication.VM.Common;
using AspNetCoreApplication.VM.Product.Model;
using AspNetCoreApplication.VM.Product.Out;
using AutoMapper;

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
            #region[ Product ]
            CreateMap<ProductModel, ProductVM>();
            CreateMap<ProductOut, ProductOutVM>();
            #endregion

            #region[ ResultService]
            CreateMap<ResultService, ResultServiceVM>();
            #endregion
        }
    }
}
