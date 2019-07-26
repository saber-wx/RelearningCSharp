using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Repositorys
    {
        public Repositorys()
        {
            CurrentContext = new SQLContext();
        }

        public SQLContext CurrentContext { get; set; }

        public void Flush()
        {
            CurrentContext.SaveChanges();
        }
    }
}
