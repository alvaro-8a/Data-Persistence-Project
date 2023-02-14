using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField playerNameInput;

    public void StartGame()
    {
        PlayerData.Instance.playerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }

    public void QuitGameClicked()
    {
        PlayerData.Instance.SavePlayerData();

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

}
