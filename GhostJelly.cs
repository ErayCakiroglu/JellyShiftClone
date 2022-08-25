using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostJelly : MonoBehaviour
{
    public static GhostJelly instance;
    [SerializeField] Transform[] ghostPoses;
    int index;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    /*Oyun objesinin aldığı parametreye göre boyutlarının değişmesini sağlayan metot.*/
    public void ChangeScaleOfTheGhost(Vector3 scale)
    {
        scale.y *= 1.75f;
        transform.localScale = scale;
    }

    /*Oyun objesinin pozisyonunun değişmesini sağlayan metot.*/
    public void ChangePositionOfTheGhost()
    {
        index++;

        if(ghostPoses.Length > index)
        {
            transform.position = ghostPoses[index].position;
        }
    }
}
