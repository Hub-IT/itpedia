using System.Collections.Generic;
using System.Web;

namespace ItPedia.Notifications
{
    public class Flash
    {
        private static Dictionary<string, string> _flashDictionary;

        public static void Success(string message)
        {
            Alert(message, "alert-success");
        }

        public static void Error(string message)
        {
            Alert(message, "alert-danger");
        }

        public static void Info(string message)
        {
            Alert(message, "alert-info");
        }

        public static bool HasAlert()
        {
            return HttpContext.Current.Session["flash"] != null;
        }

        public static string GetMessage()
        {
            StoreAlert();

            return _flashDictionary["message"];
        }

        private static void StoreAlert()
        {
            if (!HasAlert()) return;

            _flashDictionary = ((Dictionary<string, string>) HttpContext.Current.Session["flash"]);

            HttpContext.Current.Session["flash"] = null;
        }

        public static string GetLevel()
        {
            StoreAlert();

            return _flashDictionary["level"];
        }

        private static void Alert(string message, string level)
        {
            var flash = new Dictionary<string, string>
            {
                {"message", message},
                {"level", level}
            };

            HttpContext.Current.Session["flash"] = flash;
        }
    }
}