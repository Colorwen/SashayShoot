using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Debug.Log("kaishi");
        StartCoroutine(AwakeScene());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator AwakeScene()
    {

        yield return new WaitForSeconds(0.1f);
        Application.LoadLevelAsync("MainGame_01");
        StopAllCoroutines();
    }
}
