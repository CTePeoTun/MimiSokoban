using UnityEngine;

namespace MimiSokoban.Level
{
    public class LevelGateway : ILevelGateway
    {
        private const string Path = "Levels";
    
        public void Load()
        {
            var textAsset = Resources.LoadAll<TextAsset>(Path);
            LevelParser.LevelFileConvertToArray(textAsset[0]);
        }

        public void GetLevel()
        {
        
        }
    }

    public interface ILevelGateway
    {
        void Load();
    }

    public class LevelUsecase
    {
        private readonly ILevelGateway levelGateway;

        public LevelUsecase()
        {
            levelGateway.Load();
        }
    }

    public class LevelData
    {
        private int id;
        private string[,] map;

        public LevelData(int id, string[,] map)
        {
            this.id = id;
            this.map = map;
        }
    }
}