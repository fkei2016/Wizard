using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    public enum GameScene
    {
        Title,
        Select,
        MagicSelect,
        Play,
        Result
    }

    [SerializeField]
    private GameScene nextScene;

	// Use this for initialization
	public void GoToScene() {

        SceneManager.LoadScene(nextScene.ToString());
    }

}
