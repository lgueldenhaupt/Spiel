using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResumeGame()
    {
        SceneManager.LoadScene(1);
    }

    //Closes the application completely
    public void QuitGame()
    {
        Application.Quit();
    }
}
