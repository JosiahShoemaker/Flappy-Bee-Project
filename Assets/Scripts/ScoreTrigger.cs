using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public Game game;


    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Bee")
        {
            game.BeePassedObstacle();
        }
    }
}
