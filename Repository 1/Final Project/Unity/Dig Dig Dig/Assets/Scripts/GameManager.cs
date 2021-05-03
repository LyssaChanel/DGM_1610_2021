using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI scoreText;
    // public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameText;
    public TextMeshProUGUI overText;
    public Button restartButton;
    public GameObject titleScreen;
    public GameObject gameScene;
    public GameObject gameOver;
    private int score;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 15;
    private float startDelay = 3;
    private float spawnIntervalStart = 5;
    private float waveCount = 0;
    private float spawnRate = 5;
    public GameObject[] flagPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        titleScreen.gameObject.SetActive(true);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;
        titleScreen.gameObject.SetActive(false);
        gameScene.gameObject.SetActive(true);
        UpdateScore(0);
        spawnRate /= difficulty;
        StartCoroutine(SpawnRandomFlag());
        // StartCoroutine(spawnManager.SpawnRandomFlag());
    }
    IEnumerator SpawnRandomFlag()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0.5f,Random.Range(-spawnRangeZ,spawnRangeZ));
            int flagIndex = Random.Range(0, flagPrefabs.Length);
            Instantiate(flagPrefabs[flagIndex], spawnPos, flagPrefabs[flagIndex].transform.rotation);
            UpdateScore(0);
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOver.gameObject.SetActive(true);
        isGameActive = false;
        gameText.gameObject.SetActive(true);
        overText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
