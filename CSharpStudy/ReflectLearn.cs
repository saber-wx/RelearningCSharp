using CSharpStudy._17bang;
using System;
using System.Reflection;
namespace CSharpStudy
{
    class ReflectLearn
    {
        public static void Call()
        {
            
            Type tTokenManager = typeof(TokenManager);
            Console.WriteLine(tTokenManager);
            Console.WriteLine(
            tTokenManager.GetField("_tokens",
            BindingFlags.NonPublic | BindingFlags.Instance)
            .GetValue(new TokenManager()));

        }
    }
}
