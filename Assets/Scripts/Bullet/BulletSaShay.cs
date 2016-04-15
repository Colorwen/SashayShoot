using UnityEngine;
using System.Collections;

public class BulletSaShay : MonoBehaviour
{
    public GameObject bulletGroup;

    private float startTime;

    public bool isTriggerEnter = false;

    void Start()
    {
        startTime = Time.realtimeSinceStartup;

    }
    void Update()
    {
        // Debug.Log("gameObject.transform.localPosition:  " + gameObject.transform.localPosition);
        if (Time.realtimeSinceStartup - startTime < 2)
        {
            transform.Translate(new Vector3(0, 0, 1) * 0.8f * Time.deltaTime);
        }
        else {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("检测碰撞" + other.name);
        if (isTriggerEnter)
        {
            return;
        }
        isTriggerEnter = true;
        if (other.tag == "Cube")
        {
            //Debug.Log("gameObject.transform.localPosition:  " + gameObject.transform.localPosition);
            GameObject breakUp = Instantiate(bulletGroup, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
            //Debug.Log("breakUp.transform.localPosition:  " + breakUp.transform.localPosition);
            other.GetComponent<MeshRenderer>().materials[0].mainTexture = ColorBox.colorTexturesDic["pink"];
            Debug.Log("碰撞到Cube");
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            Debug.Log("碰撞到Player");
        }
    }
}
