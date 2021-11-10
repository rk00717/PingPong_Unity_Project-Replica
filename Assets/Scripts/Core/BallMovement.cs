// This script will manage to launch the ball on the board in any direction (randomly)
// and also manage score system of the player (Adding score to respective player)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallMovement : MonoBehaviour{
    [SerializeField]
    private float speed = 5;

    [SerializeField]
    public float cooldown = 3f;
    private float nextFreeze;

    private float seconds = 0;
    [SerializeField]
    private TextMeshProUGUI canvas;

    public bool resetScore = false;
    public bool isCooldownTrigger = false;

    private int xDir, yDir;

    private Rigidbody2D body;

    [SerializeField]
    private PaddleMovement player1;
    [SerializeField]
    private PaddleMovement player2;

    void Start(){
        body = GetComponent<Rigidbody2D>();

        nextFreeze = cooldown + Time.time;
        isCooldownTrigger = true;
        seconds = cooldown;
    }

    void Update(){
        if(isCooldownTrigger){
            if(Time.time>nextFreeze){
                ResetGame();
            }
            if(seconds != 0){
                seconds -= 1 * Time.deltaTime;
                canvas.text = seconds.ToString("0");
            }
        }else{
            canvas.text = "";
        }
    }

    // this will launch player in Pseudo-Random Direction
    void Launch(){
        xDir = GiveAngle();
        yDir = GiveAngle();

        body.velocity = new Vector2(xDir * speed, yDir * speed);
    }

    // This will return the angles to launch the ball on a direction
    int GiveAngle(){
        int value = Random.Range(0, 2);
        if(value == 0) return -1;
        else return 1;
    }

    // This will reset the game/board as required.
    void ResetGame(){
        if(resetScore){
            player1.scorePoint = 0;
            player2.scorePoint = 0;

            resetScore = false;
        }

        player1.gameObject.transform.position = new Vector2(-8, 0);
        player2.gameObject.transform.position = new Vector2(8, 0);

        transform.position = Vector2.zero;

        isCooldownTrigger = false;
        seconds = cooldown;

        Launch();
    }

    // Checking if ball itself hit any player collider/goal or not if so then we will add the points to respective player and reset the board to continue the game.
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.layer == 6){
            if(collision.gameObject.tag == "Player_1"){
                player2.scorePoint++;
            }
            if(collision.gameObject.tag == "Player_2"){
                player1.scorePoint++;
            }

            isCooldownTrigger = true;
            nextFreeze = Time.time + cooldown;
        }
    }
}