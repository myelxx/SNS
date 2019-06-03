using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    interface IPost
    {
        void AddPost(Post post);
        void DeletePost(int id);
        void Edit(Post post);
        void View(Post post);
    }
}
