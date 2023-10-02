using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace spm
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                try
                {
                    if (args[0].Contains('i') || args[1].Contains("install") && args[0] != null)
                    {
                        try
                        {
                            get(args[1], args[2]);
                        }
                        catch
                        {
                            get(args[1]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Special-PM 0.1 by frostysf\n");
                    Console.Write("spm> ");
                    string ii = Console.ReadLine();
                    if (ii != null)
                    {
                        if (ii.Split(' ')[0].Contains("i") || ii.Split(' ')[0].Contains("install"))
                        {
                            if (ii.Split(' ')[1] != null)
                            {
                                if (ii.Split(' ')[2] != null)
                                {
                                    get(ii.Split(' ')[1], ii.Split(' ')[2]);
                                }
                                else
                                {
                                    get(ii.Split(' ')[1]);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void get(string name, string path)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("a", "a");
                    try
                    {
                        wc.DownloadFile("https://raw.githubusercontent.com/FrostySF/SpecialKeySite/master/modules/i/" + name + ".spk", path + "/" + name + ".spk");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void get(string name)
        {
            get(name, @"C:/Users/User/Desktop/");
        }
    }
}
