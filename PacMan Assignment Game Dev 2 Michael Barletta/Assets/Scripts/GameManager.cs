using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static int score;
    public static int pelletsRemaining;
    public static GameManager game;
    [SerializeField] private GameObject panel;
    [SerializeField] private TMPro.TextMeshProUGUI endText;

    void Awake()
    {
        GameManager.game = this;
    }
    void Start()
    {
        score = 0;
        pelletsRemaining = GameObject.FindGameObjectsWithTag("ScorePellet").Length;
    }

    public static void AddScore(int amount)
    {
        score += amount;
    }

    public static void EndGame(string message)
    {
        game.panel.SetActive(true);
        game.endText.text = message;
        Time.timeScale = 0f;
    }
    
    public void ResetGame()
    {   
        Time.timeScale = 1f;
        score = 0;
        pelletsRemaining = GameObject.FindGameObjectsWithTag("ScorePellet").Length;
        game.panel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
   
