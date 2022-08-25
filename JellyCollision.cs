using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyCollision : MonoBehaviour
{
    /*Oyun objesinin Obstacle ile etkileşime girdiği vakit pozisyonunun değiştiği metot.*/
    void OnTriggerEnter(Collider contact)
    {
        if(contact.gameObject.tag == "Obstacle")
        {
            GhostJelly.instance.ChangePositionOfTheGhost();
        }
    }
}
