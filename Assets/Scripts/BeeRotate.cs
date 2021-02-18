using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeRotate : MonoBehaviour
{

    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
