using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Score : MonoBehaviour
{
  public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = variables.player2score.ToString();
    }
}
