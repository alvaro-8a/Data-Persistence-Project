using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    public string playerName;
    public string bestScoreName;
    public int bestScore;

    class SaveData
    {
        public string bestScoreName;
        public int score;
    }

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SavePlayerData()
    {

    }
}
