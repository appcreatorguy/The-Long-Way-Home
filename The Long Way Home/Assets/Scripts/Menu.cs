using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void Play ()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LevelSelect ()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Quit ()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
