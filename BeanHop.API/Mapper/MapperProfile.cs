using AutoMapper;
using BeanHop.Model.Model;
using BeanHop.Contract.AppUser;
using static System.Net.WebRequestMethods;
using BeanHop.Contract.Product;

namespace BeanHop.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region AppUser
            CreateMap<AppUser, UserResponse>();
            CreateMap<UserRequest, AppUser>();
            CreateMap<UserRegistration, AppUser>();
            #endregion

            #region Product
            CreateMap<Product, ProductReponse>()
                    .ForMember(dest => dest.RoastLevelName, otp => otp.MapFrom(src => src.RoastLevel.RoastName));
            CreateMap<ProductRequest, Product>();
            #endregion
        }
    }
}
