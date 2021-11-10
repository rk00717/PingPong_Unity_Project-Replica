using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour{
    private Text canvas;
    private bool makeChange = false;

    [SerializeField]
    private Slider slider;

    void Start(){
        canvas = GetComponent<Text>();
    }

    void Update(){
        if(makeChange){
            canvas.text = "Rounds (" + slider.value + ") :";
            makeChange = false;
        }
    }

    public void Change(){
        makeChange = true;
    }
}