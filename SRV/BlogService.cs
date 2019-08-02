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

        public BlogService(IHttpContextAccessor accessor, 
            BlogRepository blogRepository, 
            UserRepository userRepository):base(accessor,userRepository)
        {
            _blogRepository = blogRepository;
        }

        public Blog Get(int id)
        {
            return _blogRepository.Get(id)
                .Include(b=>b.Author)
                .Include(b=>b.Posts)
                    .ThenInclude(p=>p.Author)
                .SingleOrDefault();
        }

        //��ȡ��ҳ�Լ������ߵĽ��
        public IList<Blog> Get(int? bloggerId, int pageIndex,int pageSize)
        {
            //��ȡ����blogs
            IQueryable<Blog> blogs = _blogRepository.Get();
            //�����blogger�����˽��
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
