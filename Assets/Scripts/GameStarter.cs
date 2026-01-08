using UnityEngine;

public class GameStarter : MonoBehaviour
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
    [SerializeField] GameObject scoreText;

    [Header ("In game elements")]
    [SerializeField] PipeSpawner pipeSpawner;

    [Header ("Game Starter")]
    [SerializeField] GameStarter gameStarter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
        backgroundloop1.enabled = true;
        backgroundloop2.enabled = true;
        groundloop1.enabled = true;
        groundloop2.enabled = true;
        pipeSpawner.enabled = true;

        playerRB.gravityScale = 2.8f;
        playerController.enabled = true;

        scoreText.SetActive(true);
        startscreen.SetActive(false);
        gameStarter.enabled = false;
        }
    } 
}