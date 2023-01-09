using AutoMapper;
using Domain.Entities;
using Service.Services.DTOs.AppUser;
using Service.Services.DTOs.Banner;
using Service.Services.DTOs.Blog;
using Service.Services.DTOs.BlogImage;
using Service.Services.DTOs.Comment;
using Service.Services.DTOs.Contact;
using Service.Services.DTOs.Movflix;
using Service.Services.DTOs.Movie;
using Service.Services.DTOs.MovieCategory;
using Service.Services.DTOs.MovieComment;

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

            CreateMap<CommentCreateDto, Comment>().ReverseMap();
            CreateMap<CommentListDto, Comment>().ReverseMap();

            CreateMap<MovieCommentCreateDto, MovieComment>().ReverseMap();
            CreateMap<MovieCommentListDto, MovieComment>().ReverseMap();

            CreateMap<ContactListDto, Contact>().ReverseMap();
            CreateMap<ContactUpdateDto, Contact>().ReverseMap();

            CreateMap<BannerCreateDto, Banner>().ReverseMap();
            CreateMap<BannerUpdateDto, Banner>().ReverseMap();
            CreateMap<BannerListDto, Banner>().ReverseMap();


            CreateMap<MovieCreateDto, Movie>().ReverseMap();
            CreateMap<MovieUpdateDto, Movie>().ReverseMap();
            CreateMap<MovieListDto, Movie>().ReverseMap();
            CreateMap<MovieGetDto, Movie>().ReverseMap();


            CreateMap<MovieCategoryCreateDto, MovieCategory>().ReverseMap();
            CreateMap<MovieCategoryUpdateDto, MovieCategory>().ReverseMap();            
            CreateMap<MovieCategoryListDto, MovieCategory>().ReverseMap();
            

            CreateMap<BlogImageListDto, BlogImage>().ReverseMap();

            CreateMap<AppUser, RegisterDto>().ReverseMap();
            CreateMap<UserDto, AppUser>().ReverseMap();
            CreateMap<AppUser, UpdatePasswordDto>().ReverseMap();
            CreateMap<AppUser, UpdateUserDto>().ReverseMap();



        }
    }
}
