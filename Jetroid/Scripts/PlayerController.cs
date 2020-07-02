using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Vector2 moving = new Vector2 ();
	
	public bool isPaused = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		moving.x = moving.y = 0;

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (isPaused)
			{
				Time.timeScale = 1;
				isPaused = false;
			}
			else
			{
				Time.timeScale = 0;
				isPaused = true;
			}
		}

		if (!isPaused)
        {
			if (Input.GetKey("right"))
			{
				moving.x = 1;
			}
			else if (Input.GetKey("left"))
			{
				moving.x = -1;
			}

			if (Input.GetKey("up"))
			{
				moving.y = 1;
			}
			else if (Input.GetKey("down"))
			{
				moving.y = -1;
			}
		}

	}
}
