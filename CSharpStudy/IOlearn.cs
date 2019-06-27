using System.IO;
using System.Text;

namespace CSharpStudy
{
    public class IOlearn
    {
        public static void Call()
        {
            string path = "D:\\17bang\\emile.txt ";
            byte[] data = System.Text.Encoding.Default.GetBytes("saber.wx@qq.com ");
            string emile1 = "666.xx@qq.com ";
            IOlearn emileTxt = new IOlearn();
            emileTxt.CreateTxt(path, data);
            File.AppendAllText(path, emile1);


        }

        //创建txt文件
        private void CreateTxt(string path, byte[] data)
        {
            FileStream txt = new FileStream(path, FileMode.Create);
            txt.Write(data, 0, data.Length);
            txt.Flush();
            txt.Dispose();
            txt.Close();
        }

        private void CreateTxt(string path, string data)
        {
            FileStream txtStream = new FileStream(path, FileMode.Create);
            StreamWriter txt = new StreamWriter(txtStream);
            txt.Write(data);
            txt.Flush();
            txt.Close();
            txt.Dispose();
            txtStream.Close();
            txtStream.Dispose();
        }

    }
}