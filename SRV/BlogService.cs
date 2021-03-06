using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;


namespace SRV
{
    public class BlogService : BaseService, IBlogService
    {

        private BlogRepository _blogRepository;
        private PostRepository _postRepository;

        public BlogService(IHttpContextAccessor accessor, 
            BlogRepository blogRepository,
            PostRepository postRepository, 
            UserRepository userRepository):base(accessor,userRepository)
        {
            _blogRepository = blogRepository;
            _postRepository = postRepository;
        }

        public void Comment(int id, Post newPost)
        {
            newPost.Author = CurrentUser;
            newPost.Blog = _blogRepository.Get(id).SingleOrDefault();

            newPost.Publish();
            //_postRepository.Save(newPost);
        }

        public void Delete(int id)
        {
            _blogRepository.Delete(Get(id));
            //_blogRepository.Flush();
        }

        public Blog Get(int id)
        {
            return _blogRepository.Get(id)
                .Include(b=>b.Author)
                .Include(b=>b.Posts)
                    .ThenInclude(p=>p.Author)
                .SingleOrDefault();
        }

        //获取分页以及有作者的结果
        public IList<Blog> Get(int? bloggerId, int pageIndex,int pageSize)
        {
            //获取所有blogs
            IQueryable<Blog> blogs = _blogRepository.Get();
            //如果有blogger，过滤结果
            if (bloggerId.HasValue)
            {
                blogs = _blogRepository.GetByAuthor(bloggerId.Value);
            }//else {}
            return _blogRepository.Paged(blogs, pageIndex, pageSize).ToList();
        }

        public Blog Publish(Blog blog)
        {

            //Blog blog = mapper.Map<Blog, Blog>(dBlog);
            //blog.Author = CurrentUser;
            ////blog.Publish();
            return _blogRepository.Save(blog);
        }
    }

}
