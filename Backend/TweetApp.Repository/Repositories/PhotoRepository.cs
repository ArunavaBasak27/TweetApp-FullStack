using TweetApp.Repository.Contexts;
using TweetApp.Repository.Entities;
using TweetApp.Repository.Interfaces;

namespace TweetApp.Repository.Repositories
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
        private readonly ApplicationDbContext _db;
        public PhotoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
