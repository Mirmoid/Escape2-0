using UnityEngine;
using UnityEngine.SceneManagement;

public class ForNightGame : MonoBehaviour
{
    public void ChangeGame(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}