using Domain.Business;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    class PostRepository : PostAction, IPost
    {
        Post _postList;

        List<Post> users = new List<Post>()
        {
            new Post () { UserId = 1, PostId = 1, DateTimeCreated = DateTime.Now },
            new Post () { UserId = 2, PostId = 2, DateTimeCreated = DateTime.Now },
            new Post () { UserId = 3, PostId = 3, DateTimeCreated = DateTime.Now },
            new Post () { UserId = 2, PostId = 4, DateTimeCreated = DateTime.Now },
        };

        public PostRepository(Post postContext)
        {
            _postList = postContext;
        }

        public Post AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Post DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Post EditPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Post ViewPost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
