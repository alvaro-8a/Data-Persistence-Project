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
    [SerializeField] TextMeshProUGUI bestScoreText;

    private void Start()
    {
        bestScoreText.SetText("Best Score: " + PlayerData.Instance.bestScoreName + " : " + PlayerData.Instance.bestScore);
        playerNameInput.text = PlayerData.Instance.playerName;
    }

    public void StartGame()
    {
        PlayerData.Instance.playerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }

    public void QuitGameClicked()
    {
        PlayerData.Instance.SaveBestScore();

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

}
