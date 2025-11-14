using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    // Этот метод можно вызвать через OnClick Events
    public void exitGame()
    {
        Application.Quit(); 
    }
}