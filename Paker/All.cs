using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paker
{
    static class all
    {
        //---------------------------------------------------------------------------
        //---------------------------------------------------------------------------
        //                      StartUp & Shutdown
        //---------------------------------------------------------------------------
        //---------------------------------------------------------------------------
        static all()
        {
        }
        public static void End()
        {
            main = null;
        }
        public static void InitManager()
        {
        }

        //Form
        public static Form1 main;

        //Pak
        public static Pak pak = new Pak();
        public static string savePath;
        public static string filePath;
        public static string importPath;

        //Bytes
        public const long KB = 1024;
        public const long MB = 1048576;
        public const long GB = 1073741824;
        public const long MAXSIZE = GB;

        //Resets
        public static void ResetAll()
        {
            ResetGlobal();
            ResetMain();
        }
        public static void ResetGlobal()
        {
            pak = new Pak();
        }
        public static void ResetMain()
        {
            main.ResetLocalData();
            main.ResetControls();
        }

        //Helper
        public static string GetPath(string filepath)
        {
            int index = filepath.Length - 1;
            while (true)
            {
                if (filepath[index] == '\\')
                    break;
                if (index == 0)
                    return "";
                index--;
            }

            return filepath.Remove(index+1);
        }
        public static string GetAsCharArray(string word)
        {
            string final = "{";

            for (int i = 0; i < word.Length; i++)
            {
                final += "'" + word[i] + "'";
                if (i != word.Length - 1)
                    final += ",";
            }
            final += "}";

            return final;
        }

    }
}
