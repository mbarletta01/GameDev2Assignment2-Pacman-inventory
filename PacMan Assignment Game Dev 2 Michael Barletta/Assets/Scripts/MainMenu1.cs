using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("PlayGame called");
        SceneManager.LoadScene("Maze");
    }
}
