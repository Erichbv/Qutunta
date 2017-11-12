using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public static int score = 0;
    public string score_string = "SCORE ";
    public Text text_score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (text_score != null)
        {
            text_score.text = score_string+score.ToString() ;
        }
	}
}
