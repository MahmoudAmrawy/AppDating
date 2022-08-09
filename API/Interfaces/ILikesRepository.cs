using API.Dtos;
using API.Entities;
using API.Helpers;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likeUserId);
        Task<AppUser> GetUserWithLikes(int userId);

        Task<pagedList<LikeDto>> GetUserLikes(LikesParams likesParams);

    }
}
