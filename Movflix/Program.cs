using Domain.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Repository;
using Repository.Data;
using Repository.Interfaces;
using Service.Services;
using Service.Services.Interfaces;
using Service.Services.Mappings;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
   
});

builder.Services
    .AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();
     

builder.Services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
                        ClockSkew = TimeSpan.Zero // remove delay of token when expire
                    };
                });


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IMovflixRepository, MovlixRepository>();

builder.Services.AddScoped<IMovflixService, MovflixService>();

builder.Services.AddScoped<IBlogRepository, BlogRepository>();

builder.Services.AddScoped<IBlogService, BlogService>();

builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddScoped<ICommentService, CommentService>();

builder.Services.AddScoped<IMovieCommentRepository, MovieCommentRepository>();

builder.Services.AddScoped<IMovieCommentService, MovieCommentService>();

builder.Services.AddScoped<IContactRepository, ContactRepository>();

builder.Services.AddScoped<IContactService, ContactService>();

builder.Services.AddScoped<IBannerRepository, BannerRepository>();

builder.Services.AddScoped<IBannerService, BannerService>();

builder.Services.AddScoped<IPricingRepository, PricingRepostory>();

builder.Services.AddScoped<IPricingService, PricingService>();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

builder.Services.AddScoped<IServiseService, ServiseService>();

builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddScoped<IMovieService, MovieService>();

builder.Services.AddScoped<IMovieCategoryRepository, MovieCategoryRepository>();

builder.Services.AddScoped<IMovieCategoryService, MovieCategoryService>();

builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddSwaggerGen(options =>
{

    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}


app.UseCors();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
