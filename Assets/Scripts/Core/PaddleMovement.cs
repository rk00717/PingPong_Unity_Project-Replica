// This script will only used for the paddle movement.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaddleMovement : MonoBehaviour{
    [SerializeField]
    private float speed;

    public string name = "";
    public int scorePoint = 0;

    private float yDir;

    [SerializeField]
    private string Player_Control;

    [SerializeField]
    private TextMeshProUGUI displayBoard;

    private Rigidbody2D body;

    void Start(){
        body = GetComponent<Rigidbody2D>();
    }

    void Update(){
        yDir = Input.GetAxis(Player_Control);

        body.velocity = new Vector2(0f, yDir * speed);
        
        displayBoard.text = name;
    }
}