
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    public void Pause()
    {
        this.pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        this.pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
