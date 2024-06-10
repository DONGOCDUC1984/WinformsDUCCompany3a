using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace WinformsDUCCompany3a.Tools
{
    public class CommonServices
    {
        public static string conString = "Data Source=DESKTOP-V8UBCG7\\SQLEXPRESS;Initial Catalog=WinformsDUCCompany3;Integrated Security=True";
        // Show Popup notification
        public static void ShowPopUpNoti(string s)
        {
            PopupNotifier popupNotifier = new PopupNotifier();
            popupNotifier.Image = Properties.Resources.information64;
            popupNotifier.TitleText = "Message";
            popupNotifier.ContentText = s;
            popupNotifier.Popup();
        }
        // Get Hashed Password
        public static string GetHashedPassword(string input)
        {
            MD5 md5 = MD5.Create();
            // Convert the input string to a byte array and compute the hash
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new stringbuilder to collect the bytes and create a string
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
