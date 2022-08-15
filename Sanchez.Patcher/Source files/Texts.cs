using System;
using System.Collections.Generic;

namespace MT2.Patcher.Source
{
    class Texts
    {
        private static Dictionary<string, string> Text = new Dictionary<string, string>
        {
            {"UNKNOWNERROR",                    "Nieznany błąd: \n{0}"},
            {"MISSINGBINARY",                   "Brak {0}."},
            {"CANNOTSTART",                     "error."},
            {"NONETWORK",                       "Problem z serwerem."},
            {"CONNECTING",                      "Łączenie z serwerem..."},
            {"LISTDOWNLOAD",                    "Pobieram liste plików..."},
            {"CHECKFILE",                       "{0} sprawdzam..."},
            {"DOWNLOADFILE",                    "{0} pobieranie... {1}/ {2}"},
            {"COMPLETEPROGRESS",                "Całkowity Postęp: {0}%"},
            {"CURRENTPROGRESS",                 "Postęp: {0}%  |  {1} kb/s"},
            {"CHECKCOMPLETE",                   "Wszystkie pliki zostały sprawdzone."},
            {"DOWNLOADCOMPLETE",                "Wszystkie pliki zostały pobrane."},
            {"DOWNLOADSPEED",                   "{0} kb/s"},
            {"VERSION",                         "v{0:10}"}
        };

        public static string GetText(string Key, params object[] Arguments)
        {
            foreach (var currentItem in Text)
            {
                if(currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments); 
                }
            }

            return null;
        }
    }
}
