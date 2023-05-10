using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingAPI.MT4Server;
using System.IO;

namespace ApiClient
{
    public class ApiMini
    {

        public static void LoadServer(string Path, string filename)
        {
            try
            {


                string completestr = String.Format(@"{0}\config\{1}.srv", Path, filename);
                MainServer srv = QuoteClient.LoadSrv(completestr);
                fileAction.WriteFile(@"f:\log2.txt", completestr);

            }
            catch (Exception ex)
            {
                fileAction.WriteFile(@"f:\log2.txt", ex.Message);

            }
        }


    }
    public class fileAction
    {
        public static string ReadFile(string pth)
        {
            try
            {
                if (!File.Exists(pth))
                {
                    return "File not Exist!!";
                }



                string ReadText;
                FileStream f = new FileStream(pth, FileMode.Open);
                StreamReader sr = new StreamReader(f);
                ReadText = sr.ReadToEnd();
                sr.Close();
                f.Close();

                return ReadText;
            }
            catch (Exception)
            {

                Exception ex = new Exception();
                return ex.Message;
            }
        }

        public static bool WriteFile(string pth, string Value)
        {
            try
            {
                FileStream f;
                if (!File.Exists(pth))
                {
                    f = new FileStream(pth, FileMode.CreateNew);
                }
                else
                {
                    f = new FileStream(pth, FileMode.Append);
                }

                StreamWriter sw = new StreamWriter(f);
                sw.WriteLine(Value);
                sw.Close();
                f.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }




        }

        public static string DeleteFile(string pth)
        {
            try
            {

                if (File.Exists(pth))
                {
                    File.Delete(pth);
                    return "Success Deleted...";
                }
                return "File not Exist...";

            }
            catch (Exception)
            {

                Exception ex = new Exception();
                return ex.Message;
            }

        }

        public static string CreateFile(string pth)
        {
            try
            {

                FileStream f;
                if (!File.Exists(pth))
                {
                    f = new FileStream(pth, FileMode.CreateNew);
                    f.Close();
                    return "Created File ...";
                }
                return "File Is Exist";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static bool CheckExistFile(string pth)
        {
            try
            {
                if (File.Exists(pth))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }


        }

    }
}
