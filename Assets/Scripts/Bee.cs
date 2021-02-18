using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{

    public float g = -0.5f;
    public float flapForce = 15f;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -0.5f, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, flapForce, 0));
        }
    }

}