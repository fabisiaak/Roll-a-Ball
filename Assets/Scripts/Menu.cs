using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject showOptions;
    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void ShowOptions()
    {
        showOptions.SetActive(!showOptions.activeInHierarchy);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
