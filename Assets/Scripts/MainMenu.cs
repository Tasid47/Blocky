using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        LevelLoader.NextLevel();
    }
    public void QuitGame()
    {
        Debug.Log("Bye!");
        Application.Quit();
    }
}
