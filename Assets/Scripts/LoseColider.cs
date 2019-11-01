using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseColider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // only use when confident scene name wont change
        SceneManager.LoadScene("Game Over");
    }
}
