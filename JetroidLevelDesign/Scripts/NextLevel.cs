using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string scene;
    public bool loadLock;
    public Text playerScores;
    public Text playerCrystalsCollected;

    public void LoadNextLevel()
    {

        Debug.Log(PlayerSceneManager.Instance.player.scores.playerScores);
        Debug.Log(PlayerSceneManager.Instance.player.crystalsCollected.items);
        Debug.Log(PlayerSceneManager.Instance.player.levels.currentLevel);

        SceneManager.LoadScene("Level_0"+(PlayerSceneManager.Instance.player.levels.nextLevel).ToString());
    }

    private void Start()
    {
        playerScores = GameObject.Find("PlayerScores").GetComponent<Text>();
        playerScores.text = "+ " + PlayerSceneManager.Instance.player.scores.playerScores.ToString();
        playerCrystalsCollected = GameObject.Find("PlayerCrystalsCollected").GetComponent<Text>();
        playerCrystalsCollected.text = "+ " + PlayerSceneManager.Instance.player.crystalsCollected.items.ToString();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !loadLock)
        {
            loadLock = true;
            LoadNextLevel();
        }

    }
}
