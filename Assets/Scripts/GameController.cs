using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector2 spawnValues;
    public int AsteroidCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public int score;
    public Text scorText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while(true)
        for (int i = 0; i < AsteroidCount; i++)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
            Instantiate(Asteroid, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);

        }

       
    }
    public void AddScore(int value)
    {
        score += value;
        UpdateScore();
        if (score == 200)
        {
            SceneManager.LoadScene("Victoria");
        }
    }
    void UpdateScore()
    {
        scorText.text = "Score: " + score;
    }
}

