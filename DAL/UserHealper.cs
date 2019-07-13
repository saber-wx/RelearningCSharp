using System;
using System.Data;

namespace DAL
{
    public class UserHealper
    {
        private static DataTable _users = new DataTable();
        /// <summary>
        ///在持久层(数据库)中进行查找:根据用户名获得用户Id
        /// </summary>
        /// <param name="用户名"></param>
        /// <returns>如果找到,用户Id;否则返回null</returns>
        public int? GetByName(string username)
        {
            return null;
        }

        public void Save(string name,string password)
        {

        }
        
    }


}
