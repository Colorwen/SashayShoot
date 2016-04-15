using UnityEngine;
using System.Collections;

public class CreateCube : MonoBehaviour
{
    public GameObject originalCube;
    public Transform cubeGroup;
    public GameObject[,] allSceneCube;

    public int length = 10;
    public int width = 10;

    public float adjustLength;
    public float adjustWidth;
    void Start()
    {
        Init();
    }
    public void Init()
    {
        Transform activeGameobject = GameObject.Find("ActiveGameObject").transform;
        originalCube = activeGameobject.FindChild("OriginaObjs/Cube").gameObject;
        cubeGroup = activeGameobject.FindChild("CubeGroup");
        allSceneCube = new GameObject[100, 100];
        adjustLength = originalCube.transform.localScale.x / 2;
        adjustWidth = originalCube.transform.localScale.z / 2;
        CreateAllSceneCube();
    }
    public void CreateAllSceneCube()
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                allSceneCube[i, j] = Instantiate(originalCube, new Vector3(i + adjustLength, 10, j + adjustWidth), Quaternion.identity) as GameObject;
                allSceneCube[i, j].name = "Cube_" + i + "_" + j;
                allSceneCube[i, j].transform.parent = cubeGroup;
                Debug.Log(i + "   " + j);
            }
        }
    }
}
