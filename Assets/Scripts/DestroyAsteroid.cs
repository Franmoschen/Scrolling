using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyAsteroid : MonoBehaviour
{
    public GameObject explosion;
    public GameObject PlayerExplosion;
    private GameController gameController;
    public int ScoreValue;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
       gameController = gameControllerObject.GetComponent<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary") return;
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
            SceneManager.LoadScene("GameOver");
        }
        gameController.AddScore(ScoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
     
    }
}
