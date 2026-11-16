using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "EReed_Hour16";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
