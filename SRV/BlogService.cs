using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;


namespace SRV
{
    public class BlogService : BaseService, IBlogService
    {

        private BlogRepository _blogRepository;

        public BlogService(IHttpContextAccessor accessor, 
            BlogRepository blogRepository, 
            UserRepository userRepository):base(accessor,userRepository)
        {
            _blogRepository = blogRepository;
        }

        public Blog Get(int id)
        {
            return _blogRepository.Get(id);
            //Blog blog = _blogRepository.Get(id);
            //return mapper.Map<Blog, Blog>(blog);
        }

        public IList<Blog> Get()
        {
            return _blogRepository.Get();
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
