using UnityEngine;
using System.Collections;

public class DestroyBulletGroup : MonoBehaviour
{

    void Start()
    {
        Invoke("DestroyObj", 4.0f);
    }
    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
