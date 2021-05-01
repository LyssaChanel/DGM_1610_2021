using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public GameObject titleScreen;
    public Button restartButton;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    private int score;
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        // titleScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }
    // Spawns objects every 1 second
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    IEnumerator SpawnTarget()
    {
        while(isGameActive) {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            UpdateScore(5);
        }
    }
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty)
    {
        titleScreen.gameObject.SetActive(false);
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        spawnRate /= difficulty;
    }
}
