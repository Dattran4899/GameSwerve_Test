
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu : MonoBehaviour
{
    public void Playmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
        
    }
    
}
