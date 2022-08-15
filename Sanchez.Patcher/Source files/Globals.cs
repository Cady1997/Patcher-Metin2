using System.Collections.Generic;

namespace MT2.Patcher.Source
{
    class Globals
    {
        public static string ServerURL      = "https://pandorum.fra1.digitaloceanspaces.com/patcher/";
        public static string PatchlistName  = "patchlist.txt";
        public static string BinaryName     = "metin2client.exe";

        public static pForm pForm;

        public static List<File>    Files    = new List<File>();
        public static List<string>  OldFiles = new List<string>();

        public static long fullSize;
        public static long completeSize;

        public struct File
        {
            public string Name;
            public string Hash;
            public long   Size;
        }
    }
}
