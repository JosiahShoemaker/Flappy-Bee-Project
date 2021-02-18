using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlayOnCollision : MonoBehaviour
{
    public Game game;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bee")
        {
         OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
            game.EndPlay();
        }
    }
}
