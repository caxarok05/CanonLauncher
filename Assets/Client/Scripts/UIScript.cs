using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1;
    }
    public void EndGame()
    {
        Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("MainScene");
        
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void DisplayPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}
