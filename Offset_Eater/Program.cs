using System;
using System.Net;


namespace Offset_Eater
{
    class Program
    {
        static void Main(string[] args)
        {

            string cs = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.cs";
            string hpp = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.hpp";
            string json = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.hpp";
            string minJson = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.min.json";
            string toml = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.toml";
            string vb = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.vb";
            string yaml = "https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.yaml";

            Console.WriteLine("I am not responsible for whatever happens if you use these offsets. It's all on you.");
            Console.WriteLine("Big thanks to frk1 for giving us the up to date offsets with hazedumper.");
            Console.WriteLine("This tool will download all the offsets in their own .txt files (7 files). I recommend putting this in a folder before running.");
            Console.WriteLine("Before you use any of the offsets, make sure to read the 3rd line. You don't want outdated offsets do you?");
            Console.WriteLine("Start download (Y/N)?");
            string opt = Console.ReadLine();

            if (opt == "y" || opt == "Y")
            {
                Console.WriteLine("Downloading...");
                WebClient wc = new WebClient();
                wc.DownloadFile(cs, "offset_cs.txt");
                wc.DownloadFile(hpp, "offset_hpp.txt");
                wc.DownloadFile(json, "offset_json.txt");
                wc.DownloadFile(minJson, "offset_minJson.txt");
                wc.DownloadFile(toml, "offset_toml.txt");
                wc.DownloadFile(vb, "offset_vb.txt");
                wc.DownloadFile(yaml, "offset_yaml.txt");
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
