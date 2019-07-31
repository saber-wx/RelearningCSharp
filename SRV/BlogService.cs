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

        public IList<Blog> Get(int? bloggerId, int pageIndex,int pageSize)
        {
            if (bloggerId.HasValue)
            {
              //blogs =  _blogRepository.GetByAuthor(bloggerId.Value);

                return _blogRepository.GetByAuthor(bloggerId.Value,pageIndex,pageSize);
                //return _blogRepository.Paged(blogs, pageIndex, pageSize);
            }
            else
            {
                return _blogRepository.Get(pageIndex, pageSize);
            }
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
