using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Globalization;

public class Player2 : MonoBehaviour
{

    public float moveSpeed = 600f;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.LeftArrow)) {
        movement = -1f;
      } else if (Input.GetKey(KeyCode.RightArrow)) {
        movement = 1f;
      } else {
        movement = 0f;
      }
    }

    private void FixedUpdate()
    {
      transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
      if (collision.gameObject.tag == "Hexagon") {
        variables.player1score += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
    }
}
