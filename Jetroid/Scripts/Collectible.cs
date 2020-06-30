using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Dynamic;

public class Collectible : MonoBehaviour {

	public string scene;

	public Player player;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.CompareTag("Player")) {
			player = GameObject.FindObjectOfType<Player>();
			player.scores.playerScores += 100;
			player.crystalsCollected.items += 1;
			player.levels.nextLevel = player.levels.currentLevel;

			player.levels.nextLevel += 1;
			if(player.levels.nextLevel == 4)
            {
				SceneManager.LoadScene("SplashScene");
            }
			else
            {
				SceneManager.LoadScene(scene);
            }
			
			Destroy (gameObject);
		}
	}
}
