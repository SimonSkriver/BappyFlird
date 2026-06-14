using UnityEngine;

public class StartGame : MonoBehaviour
{  
    [Header ("Player")]
    [SerializeField] PlayerController playerController;
    [SerializeField] Rigidbody2D playerRB;

    [Header ("Background loops")]
    [SerializeField] BackgroundLoop backgroundloop1;
    [SerializeField] BackgroundLoop backgroundloop2;
    [SerializeField] BackgroundLoop groundloop1;
    [SerializeField] BackgroundLoop groundloop2;

    [Header ("UI elements")]
    [SerializeField] GameObject startscreen;
    [SerializeField] GameObject gameover;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject scoreText;

    [Header ("In game elements")]
    [SerializeField] PipeSpawner pipeSpawner;

    public void StartGameButton()
    {
        backgroundloop1.enabled = true;
        backgroundloop2.enabled = true;
        groundloop1.enabled = true;
        groundloop2.enabled = true;
        pipeSpawner.enabled = true;

        playerRB.gravityScale = 2.8f;
        playerController.OnJump();
        playerController.enabled = true;

        scoreText.SetActive(true);

        startscreen.SetActive(false);
        startButton.SetActive(false);

        Debug.Log("Start button pressed");
    } 
}