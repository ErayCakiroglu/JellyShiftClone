using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMove : MonoBehaviour
{
    Camera cam;
    [SerializeField] Rigidbody rb;
    [SerializeField] float lerpValue, speed, minY, maxY, minX, maxX;
    bool isGameEnded = false;
    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if(!isGameEnded)
        {
            rb.velocity = Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetButton("Fire1"))
        {
            ChangeScale();
        }
    }

    /*Oyun objelerinin mouse'dan gelen harekete göre boyutlarının değiştiği metot.*/
    void ChangeScale()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 23;

        Vector3 moveVec = cam.ScreenToWorldPoint(mousePos);

        float jellyScaleX = transform.localScale.x;
        moveVec.z = transform.localScale.z;
        moveVec.y = Mathf.Clamp(moveVec.y, minY, maxY);

        jellyScaleX = maxY / moveVec.y;

        moveVec.x = Mathf.Clamp(jellyScaleX, minX, maxX);

        transform.localScale = moveVec;

        GhostJelly.instance.ChangeScaleOfTheGhost(moveVec);
    }
}
