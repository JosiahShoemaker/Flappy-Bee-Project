using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{

    public float minY = .044f;
    public float maxY = 1.2f;
    public float speed = 1f;

   
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, minY + (maxY - minY) * Mathf.PingPong(Time.time * speed, 1), transform.position.z);
    }
}
