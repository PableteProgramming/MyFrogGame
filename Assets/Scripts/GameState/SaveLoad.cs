using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad
{
    public static GameState Game = new GameState();
    public static void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create("MiFrogGame.state");
        bf.Serialize(file, Game);
        file.Close();
    }

    public static void Load()
    {
        if (File.Exists("MiFrogGame.state"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open("MiFrogGame.state",FileMode.Open);
            Game = (GameState)bf.Deserialize(file);
            file.Close();
        }
        else
        {
            Game.level = 1;
            Game.World = 1;
            Game.skin = "Frog";
            Save();
        }
    }
}
