using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksAutoClicker
{

    public class SerializedClicker
    {

        public string Title;
        //public string ;
    }
    public static class ClickerManager
    {

        public static List<Clicker> Clickers = new List<Clicker>();

        public static void LoadClickersFromFile(string Url)
        {

        }

        //public static string toJson()
        //{

        //    var obj = new SerializedClicker
        //    {
        //        firstName = "Markoff",
        //        lastName = "Chaney",
        //        dateOfBirth = new MyDate
        //        {
        //            year = 1901,
        //            month = 4,
        //            day = 30
        //        }
        //    };
        //    var json = new JavaScriptSerializer().Serialize(obj);
        //    Console.WriteLine(json);
        //}
    }
}
