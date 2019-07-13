using DAL;
using System;

namespace BLL
{
    public class User
    {
        private static UserHealper _userHealper;
        static User() { _userHealper = new UserHealper(); }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public static void Register(User user)
        {

            _userHealper.Save(user.Name, user.Password);

            //显示欢迎语句                              (UI)
            //如果注册超过,返回True                   (BLL)
            //如果有邀请人,邀请人积分增加,收到通知       (BLL)
            //获得10个初始积分                           (BLL)
            //将用户名和密码存入数据库,的到数据库返回的Id   (DAL=>Repository)
        }

        public static bool IsNameDuplicated(string name)
        {

            return _userHealper.GetByName(name) != null;
        }

        public bool IsPasswordValid()
        {
            return Password.Length >= 4;
        }
    }
}
