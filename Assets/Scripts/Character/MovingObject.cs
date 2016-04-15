using UnityEngine;
using System.Collections;

public abstract class MovingObject : MonoBehaviour
{
    public float moveTime = 0.1f;

    private BoxCollider boxCollider;
    private Rigidbody rigidbody;
    private float inverseMoveTime;

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        rigidbody = GetComponent<Rigidbody>();
        inverseMoveTime = 1f / moveTime;
    }
}
