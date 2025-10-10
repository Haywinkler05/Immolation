using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Variables
    public GameObject pauseGame;

    // Detects for Script Enable
    private void OnEnable()
    {
        // Unlocks Cursor
        Cursor.lockState = CursorLockMode.None;
    }

    // Function to Resume Game
    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;   // Relocks the cursor
        
        pauseGame.SetActive(false);     // Sets the Game Object to Inactive
        Debug.Log("ResumeGame");    // Sends a message to the console for debugging
    }
    // Function to Return to Main Menu
    public void ReturnMenu()
    {
        // Change index once object created
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("ReturnMenu");
    }

    // Function to Fully Quit Game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
}
