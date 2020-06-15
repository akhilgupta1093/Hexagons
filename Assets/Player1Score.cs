using UnityEngine;
using UnityEngine.UI;

public class Player1Score : MonoBehaviour
{
  public Text scoreText;

    // Update is called once per frame
    void Update()
    {
      scoreText.text = variables.player1score.ToString();
    }

}
