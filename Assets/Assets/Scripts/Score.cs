using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    float playerScore = 0;

	
	// Update is called once per frame
	void Update () {
        playerScore += Time.deltaTime;
	}
    public void IncScore(int amt)
    {
        playerScore += amt;
    }
    public void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore);
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 30), "Score: " + (int)(playerScore * 100));
    }
}
