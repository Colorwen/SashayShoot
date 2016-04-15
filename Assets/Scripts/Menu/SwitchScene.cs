using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OnClick();
    }
    void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            bool ray = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, Mathf.Infinity);
            if (ray)
            {
                string name = hitInfo.transform.gameObject.name;
                OnClickObj(name);
            }
        }
    }
    void OnClickObj(string name)
    {
        switch (name)
        {
            case "GameLobby":
                Debug.Log("点击到游戏大厅");
                Application.LoadLevelAsync("MainGame_01");
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
