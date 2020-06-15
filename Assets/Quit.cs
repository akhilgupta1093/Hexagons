using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void BackToStartScreen()
    {
      SceneManager.LoadScene(0);
      variables_.score = 0;
      variables.player1score = 0;
      variables.player2score = 0;
    }

}
