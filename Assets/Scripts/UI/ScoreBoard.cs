// This script is to display the respected scores on the top of the screen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour{
    private TextMeshProUGUI scoreBoard;

    [SerializeField]
    private PaddleMovement player1;
    [SerializeField]
    private PaddleMovement player2;

    void Start(){
        scoreBoard = GetComponent<TextMeshProUGUI>();
    }

    void Update(){
        scoreBoard.text = player1.scorePoint + " : " + player2.scorePoint;
    }
}
