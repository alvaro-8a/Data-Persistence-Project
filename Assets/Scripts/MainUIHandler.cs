using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score : " + PlayerData.Instance.bestScoreName + " : " + PlayerData.Instance.bestScore; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
