using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Этот метод можно вызвать через OnClick Events
    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel"); // SampleScene - это название файла сцены, которая откроется
    }

    public void Exitgame()
    {
        Application.Quit();
    
        // Для проверки в редакторе
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}