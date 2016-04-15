using UnityEngine;
using System.Collections;

public class BulletGroup : MonoBehaviour
{
    public float force;
    void Start()
    {
        transform.localEulerAngles = new Vector3(-45, 0, -45);
        gameObject.GetComponent<Rigidbody>().AddForce(1, force, 1);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("检测碰撞");
        if (other.tag == "Cube")
        {
            other.GetComponent<MeshRenderer>().materials[0].mainTexture = ColorBox.colorTexturesDic["pink"];
            Debug.Log("碰撞到Cube");
           // Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            Debug.Log("碰撞到Player");
        }
    }
}
