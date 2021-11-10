using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataManager : MonoBehaviour{
    public float maxScore = 0;

    [SerializeField]
    private PaddleMovement player1;
    [SerializeField]
    private PaddleMovement player2;
    [SerializeField]
    private BallMovement ball;
    [SerializeField]
    private Text canvas;

    [SerializeField]
    private InputField p1IP;
    [SerializeField]
    private InputField p2IP;
    [SerializeField]
    private Slider rounds;

    [SerializeField]
    private GameObject platform;
    [SerializeField]
    private GameObject UIElements;

    void Start(){
        SetData();
    }

    void Update(){
        if(player1.scorePoint == maxScore){
            DisplayScore(player1.name);
        }
        if(player2.scorePoint == maxScore){
            DisplayScore(player2.name);
        }
    }

    void DisplayScore(string name){
        ball.resetScore = true;
        canvas.text = name + " Won";

        platform.SetActive(false);
        UIElements.SetActive(true);
    }

    void SetData(){
        player1.name = p1IP.text;
        player2.name = p2IP.text;
        maxScore = rounds.value;
    }
}