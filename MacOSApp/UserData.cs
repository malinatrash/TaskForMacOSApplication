using System.Net;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MacOSApp
{
    public sealed class StorageManager
    {
        public static void SaveData(string data, string place)
        {
            if (File.Exists(place))
            {
                File.Create(place).Close();
            }
            File.WriteAllText(place, data);
        } 
        public static string LoadData(string place)
        {
            return File.ReadAllText(place);
        }

        public static void ClearData(string placeTextField, string placeResult)
        {
            File.Delete(placeResult);
            File.Delete(placeTextField);
        }
    }
}