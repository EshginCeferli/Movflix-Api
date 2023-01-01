﻿using AutoMapper;
using Domain.Entities;
using Service.Services.DTOs.AppUser;
using Service.Services.DTOs.Blog;
using Service.Services.DTOs.BlogImage;
using Service.Services.DTOs.Movflix;
using Service.Services.DTOs.Movie;
using Service.Services.DTOs.MovieCategory;

namespace Service.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MovflixCreateDto, Movflix>().ReverseMap();
            CreateMap<MovflixUpdateDto, Movflix>().ReverseMap();
            CreateMap<MovflixListDto, Movflix>().ReverseMap();

            CreateMap<BlogCreateDto, Blog>().ReverseMap();
            CreateMap<BlogUpdateDto, Blog>().ReverseMap();
            CreateMap<BlogListDto, Blog>().ReverseMap();
            CreateMap<BlogGetDto, Blog>().ReverseMap();

            CreateMap<MovieCreateDto, Movie>().ReverseMap();
            CreateMap<MovieUpdateDto, Movie>().ReverseMap();
            CreateMap<MovieListDto, Movie>().ReverseMap();
            CreateMap<MovieGetDto, Movie>().ReverseMap();


            CreateMap<MovieCategoryCreateDto, MovieCategory>().ReverseMap();
            CreateMap<MovieCategoryUpdateDto, MovieCategory>().ReverseMap();            
            CreateMap<MovieCategoryListDto, MovieCategory>().ReverseMap();
            

            CreateMap<BlogImageListDto, BlogImage>().ReverseMap();

            CreateMap<AppUser, RegisterDto>().ReverseMap();

        }
    }
}
