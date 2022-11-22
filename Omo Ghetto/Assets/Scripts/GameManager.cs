using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { set; get; }

    private bool isGameStarted = false;
    private PlayerMove move;

    //UI fields
    public Text scoreText, coinText, modifierText;
    public float score, coinScore, modifierScore;

    private void Awake()
    {
        Instance = this;
        UpdateScores();
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    private void Update()
    {
        if(MobileInput.Instance.Tap && !isGameStarted)
        {
            isGameStarted = true;
            move.StartGame();
        }
    }

    private void UpdateScores()
    {
        scoreText.text = score.ToString();
        coinText.text = coinScore.ToString();
        modifierText.text = modifierScore.ToString();
    }
}
