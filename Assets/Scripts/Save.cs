using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Save
{
    public List<int> Scores = new List<int>(new[] {0, 0, 0});

    public Save()
    {
        var displays = GameObject.FindObjectsOfType<DisplayController>();
        foreach (var display in displays) {
            Scores.Add(display.Score);
        }
    }

    public void Apply()
    {
        var displays = GameObject.FindObjectsOfType<DisplayController>();
        // This won't crash in this simple project because we do have constant amount of displays
        for (var i = 0; i < displays.Length; ++i) {
            displays[i].SetScore(Scores[i]);
        }
    }

    public static void SaveGame()
    {
        var save = new Save();
        var bf = new BinaryFormatter();
        var file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
    }

    public static void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save")) {
            var bf = new BinaryFormatter();
            var file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            var save = (Save)bf.Deserialize(file);
            save.Apply();
            file.Close();
        }
    }
}
