using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

    public static int score;
	void Start () {
        if (Application.loadedLevel == 1) score = 0;

	}

	void Update () {
        DontDestroyOnLoad(gameObject);
	}
}
