using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Myconv
    {
        private static string dekstop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static T MyDeserialize<T>(string FileName)
        {
            if (!File.Exists(dekstop + "\\" + FileName) && FileName == "Пользователи.json")
            {
                Members defolt = new Members();
                defolt.LOGIN = "admin";
                defolt.PASSWORD = "password";
                defolt.ID = 1;
                defolt.ROLE = 1;
                List<Members> defoltlist = new List<Members>();
                defoltlist.Add(defolt);
                string json2 = JsonConvert.SerializeObject(defoltlist);
                File.WriteAllText(dekstop + "\\" + FileName, json2);
                string json = File.ReadAllText(dekstop + "\\" + FileName);
                T primer = JsonConvert.DeserializeObject<T>(json);
                return primer;

            }
            else
            {
                string json = File.ReadAllText(dekstop + "\\" + FileName);
                T primer = JsonConvert.DeserializeObject<T>(json);
                return primer;
            }



        }

        public static void Myserialize<T>(T dannie, string FileName)
        {
            string json = JsonConvert.SerializeObject(dannie);
            File.WriteAllText(dekstop + "\\" + FileName, json);
        }
    }
}