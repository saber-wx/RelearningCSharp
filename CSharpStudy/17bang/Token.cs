using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy._17bang
{
    class TokenManager
    {
        private IList<Token> _tokens { get; set; }

        public TokenManager()
        {
            _tokens = new List<Token> { Token.Registered };
        }

        public void Add(Token token)
        {
            if (_tokens.Contains(token))
            {
                _tokens = _tokens;
            }
            else
            {
                _tokens.Add(token);
            }
           
        }
        public void Remove(Token token)
        {
            _tokens.Remove(token);
        }
        public void Hass()
        {
            foreach (var item in _tokens)
            {
                Console.WriteLine(item.ToString());
            }

        }

    }

    [Flags]
    enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }
}
