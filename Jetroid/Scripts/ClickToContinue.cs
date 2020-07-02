using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour {

	public string scene;

	private bool loadLock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && !loadLock) {
			LoadScene ();
		}

		if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) && !loadLock)
        {
			LoadScene ();
        }


	}

	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene (scene);
	}
}
