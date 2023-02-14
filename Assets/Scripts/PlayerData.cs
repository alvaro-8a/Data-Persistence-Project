using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    public string playerName;
    public string bestScoreName;
    public int bestScore;

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public string bestScoreName;
        public int bestScore;
    }

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadBestScore();
    }

    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.bestScoreName = bestScoreName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            bestScoreName = data.bestScoreName;
            bestScore = data.bestScore;
        }
    }
}
