using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoMainMenu : MonoBehaviour
{
    public void OpenLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
