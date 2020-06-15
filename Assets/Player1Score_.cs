using UnityEngine;
using UnityEngine.UI;

public class Player1Score_ : MonoBehaviour
{
  public Text scoreText;

    // Update is called once per frame
    void Update()
    {
      scoreText.text = variables_.score.ToString();
    }

}
