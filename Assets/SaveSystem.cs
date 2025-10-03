using System.IO;
using UnityEngine;

public static class SaveSystem
{
    public static readonly string SAVE_FOLDER = Application.persistentDataPath + "/saves/";
    public static readonly string FİLE_EXT = ".json";

    public static void Save(string fileName, string dataToSave)
    {
        if (!Directory.Exists(SAVE_FOLDER))
        {
            Directory.CreateDirectory(SAVE_FOLDER);
        }

        File.WriteAllText(SAVE_FOLDER + fileName + FİLE_EXT, dataToSave);
    }

    public static string Load(string fileName)
    {
        string fileloc = SAVE_FOLDER + fileName + FİLE_EXT;
        if (File.Exists(fileloc))
        {
            string loadedData = File.ReadAllText(fileloc);
            return loadedData;
        }
        else return null;
    }
    

    
}
