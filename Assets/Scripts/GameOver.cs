using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [Header ("Player")]
    [SerializeField] PlayerController player;

    [Header ("UI")]
    [SerializeField] GameObject gameOver;

    void Update()
    {
        if (player.isAlive == false)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            string thisScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(thisScene);
            Time.timeScale = 1;
        }
    }
}