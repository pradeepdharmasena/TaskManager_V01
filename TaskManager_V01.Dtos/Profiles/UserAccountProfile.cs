using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_V01.Models;

namespace TaskManager_V01.Dtos.Profiles
{
    public class UserAccountProfile : Profile
    {
        public UserAccountProfile() 
        {
            CreateMap<UserAccountInDTO, UserAccount>()
                .ForMember(des => des.Projects, opt => opt.Ignore());
            CreateMap<UserAccount, UserAccountOutDTO>();   
         
        }
    }
}
