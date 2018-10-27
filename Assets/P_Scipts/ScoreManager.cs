using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of scoreManager Found");
            return;
        }

        instance = this;
    }

    

    public int Player1Score = 0;
    public int Player2Score = 0;
    public int Player3Score = 0;
    public int Player4Score = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
