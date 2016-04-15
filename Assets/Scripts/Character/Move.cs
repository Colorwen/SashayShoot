using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 2f;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h * speed, 0, v * speed) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("检测碰撞");
        if (other.tag == "Cube")
        {
            other.GetComponent<MeshRenderer>().materials[0].mainTexture = ColorBox.colorTexturesDic["pink"];
            Debug.Log("碰撞到Cube");
        }
    }
}
