using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{

    public float smoothing = 3;
    public Transform player;
    // Use this for initialization
    void Start()
    {
    }

    public void FixedUpdate()
    {
        Vector3 targetPos = player.position + new Vector3(0, 3, -4);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing * Time.deltaTime);
    }
}
