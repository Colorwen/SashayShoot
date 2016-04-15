using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AreaRatio : MonoBehaviour
{

    public Transform area;
    public List<Transform> cube = new List<Transform>();
    public string playerTextureName;
    public string opponentTextureName;
    public int playerNum;
    public int opponentNum;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            CountAreaRatio();
        }
    }
    void CountAreaRatio()
    {
        playerNum = 0;
        opponentNum = 0;
        foreach (Transform child in area)
        {
            cube.Add(child);
            Debug.Log(child.gameObject.name);
            string name = child.gameObject.GetComponent<MeshRenderer>().materials[0].mainTexture.name;
            if (name == playerTextureName)
            {
                playerNum++;
            }
            else if (name == opponentTextureName)
            {
                opponentNum++;
            }
        }
        Debug.Log("cube.Count:" + cube.Count);
        Debug.Log("playerNum:" + playerNum % cube.Count);
        Debug.Log("opponentNum:" + opponentNum % cube.Count);
    }
}
