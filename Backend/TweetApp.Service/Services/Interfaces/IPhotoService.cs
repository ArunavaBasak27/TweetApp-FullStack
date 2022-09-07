using Microsoft.AspNetCore.Http;
using TweetApp.Model.Dto;
using TweetApp.Repository.Entities;

namespace TweetApp.Service.Services.Interfaces
{
    public interface IPhotoService
    {
        Task<UserDetailsDto> AddPhoto(string username,IFormFile file);
        Task<bool> DeletePhoto(string username,int id);
        Task<bool> SetMainPhoto(string username,int id);

    }
}
