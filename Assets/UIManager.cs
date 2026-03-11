using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Start Game");
    }

    public void OpenOptions()
    {
        Debug.Log("Open Options");
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}