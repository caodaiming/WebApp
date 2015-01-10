using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Demo.ViewModels;
using WebApp.Model.Models;

namespace WebApp.Demo.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDominMappingProfiles";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UserProfileViewModel, UserProfile>();
            Mapper.CreateMap<CategoryViewModel, Category>();
        }
    }
}