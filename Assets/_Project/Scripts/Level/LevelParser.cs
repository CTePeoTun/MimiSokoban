using System.IO;
using UnityEngine;

namespace MimiSokoban.Level
{
    public class LevelParser
    {
        public static string[,] LevelFileConvertToArray(TextAsset file)
        {
            using var f = new StreamReader(file.text);
            while (!f.EndOfStream)
            {
                var s = f.ReadLine();
                Debug.Log(s);
            }
            f.Close();

            return default;
        }
    }
}