using UnityEngine;
using System.Collections;

public class SwitchScenePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        switch (other.name)
        {
            case "GameLobby":
                Debug.Log("点击到游戏大厅");
                Application.LoadLevelAsync("Loading");
                break;
            case "Shop":
                Debug.Log("点击到商店");
                break;
            case "Community":
                Debug.Log("点击到社区");
                break;
            case "ARGame":
                Debug.Log("点击到AR游戏");
                Application.LoadLevelAsync("ARGame");
                break;
            default:
                break;
        }
    }
}
