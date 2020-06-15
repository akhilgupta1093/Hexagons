using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.A)) {
        movement = -1f;
      } else if (Input.GetKey(KeyCode.D)) {
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
        variables.player2score += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
    }
}
