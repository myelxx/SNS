using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain.Entity;
using Domain.Repository;

namespace Domain.Business
{
   public class PostAction : EntityBaseClass, IPost
    {

        List<Post> _postList;

        public Post AddPost(Post post)
        {
            post.PostId = _postList.Max(p => p.PostId) + 1;
            _postList.Add(post);
            return post;
        }

        public Post DeletePost(int id)
        {
            Post post = _postList.First(p => p.PostId == id);

            if(post != null)
            {
                _postList.Remove(post);
            }

            return post;
        }

        public Post Edit(Post post)
        {
            Post editPost = _postList.First(e => e.PostId == post.PostId);

            if (editPost != null)
            {
                post.PostDetails = editPost.PostDetails;
                
            }
            return post;

        }

        public Post View(Post post)
        {
            foreach(var p in _postList)
            {
                Console.WriteLine(" Post: {0} \n Date: {1} {2} \n",  p.PostDetails, p.DateTimeCreated);
            }

            return post;
        }

        void IPost.AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        void IPost.DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        void IPost.Edit(Post post)
        {
            throw new NotImplementedException();
        }

        void IPost.View(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
