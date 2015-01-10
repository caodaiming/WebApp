using AutoMapper;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Demo.ViewModels;
using WebApp.Model.Models;
using WebApp.Web.Core.AutoMapperConverters;

namespace WebApp.Demo.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappingProfiles";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UserProfile, UserProfileViewModel>();
            Mapper.CreateMap<Category, CategoryViewModel>()
                .ForMember(x => x.CategoryId, opt => opt.MapFrom(source => source.Id));

            Mapper.CreateMap<Category, CategoriesItemViewModel>();
            Mapper.CreateMap<IPagedList<Category>, IPagedList<CategoriesItemViewModel>>().ConvertUsing<PagedListConverter<Category, CategoriesItemViewModel>>();
        }
    }
}