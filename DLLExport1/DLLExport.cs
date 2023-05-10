using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using DLLExport1.ServiceReference1;
using System.ServiceModel;
using System.ServiceModel.Description;


namespace DLLExport1
{
    public class DLLExport
    {

        static string _logPath= @"c:\Log\EventDllexport.txt";
        static string _path;

        public static string logPath
        {
            get
            {
                return _logPath;
            }      
        }
        public static string _Path 
        {
            get
            {

                return _path;
            }

            set
            {      
                
                _path = value;
            }
        }


        [DllExport("ACCNum", CallingConvention = CallingConvention.StdCall)]
        public static int ACCNum(int accnum)
        {
            //dllexportevent
            fileAction.WriteFile(logPath, accnum.ToString());
            return accnum;
        }


        [DllExport("Path", CallingConvention = CallingConvention.StdCall)]
        public static void Path([In, Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder Path, [In, Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder filename, [In, Out, MarshalAs(UnmanagedType.LPWStr)] string sprm,
         [In, Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder Password,int login,
         [In, Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder robatName)
        {
            _Path= Path.ToString();
            string FulAdd = Path.ToString() + "\\config\\" + filename.ToString() + ".srv"; 
            //dllexportevent
            fileAction.WriteFile(logPath, FulAdd);

            ClientInfo C = new ClientInfo();
            C.Login = login;
            C.Password = Password.ToString();
            C.MetaPath=FulAdd.ToString();
            C.RobotName = robatName.ToString();



            Test(C);
          
        }


        [DllExport("status", CallingConvention = CallingConvention.StdCall)]
        public static int status(int stat) 
        {
            //dllexportevent 
            fileAction.WriteFile(logPath, stat.ToString());
            return stat;
        }
        

        public static void Test(ClientInfo Value)
        {
            try
            {
                WSHttpBinding binding = new WSHttpBinding();
                EndpointIdentity identity = EndpointIdentity.CreateDnsIdentity("localhost");
                Uri uri = new Uri("http://localhost:8000/GetDataLib/GetDataService/");
                EndpointAddress address = new EndpointAddress(uri, identity);
                GetDataClient client = new GetDataClient(binding, address);

                

                client.GetAddressFileSRV(Value);
                client.Close();
            }
            catch (Exception ex) 
            {
                fileAction.WriteFile(logPath, ex.Message);
            }

        }





    }
    public class ClientInfo1
    {
        public string Password;
        public int Login;
        public string srvHost;
        public int srvPort;
        public string MetaPath;
        public string RobotName;
        public string Symbol;
        public string TimeFrame;
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
                try
                {
                    if (!Directory.Exists(@"c:\Log"))
                    {
                        // Try to create the directory.
                        Directory.CreateDirectory(@"c:\Log");
                    }
                }
                catch (IOException )
                {                    
                }

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




