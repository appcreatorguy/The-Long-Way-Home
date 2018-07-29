using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

	public void Level01 ()
    {
        SceneManager.LoadScene("Level01");
    }
    public void Level02()
    {
        SceneManager.LoadScene("Level02");
    }
    public void Level03()
    {
        SceneManager.LoadScene("Level03");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
