using AutoMapper;
using BeanHop.Model.Model;
using BeanHop.Contract.AppUser;
using static System.Net.WebRequestMethods;

namespace BeanHop.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region AppUser
            CreateMap<AppUser, UserResponse>();
            CreateMap<UserRequest, AppUser>();
            #endregion
        }
    }
}
