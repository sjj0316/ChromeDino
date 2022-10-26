using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverUI;
    private void Awake()
    {
        gameOverUI.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObject = collision.gameObject;
        if (gameObject.CompareTag("Huddle"))
        {
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
        }

    }

    
    // Start is called before the first frame update

}
