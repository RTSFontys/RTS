using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float camSpeed = 20f;
    public float panBorderthickness = 10f;

    // Update is called once per frame
    void Update()
    {

        Vector3 currentPos = transform.position;



        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderthickness)
        {
            currentPos.y += camSpeed * Time.deltaTime;
        }
         if(Input.GetKey("s") || Input.mousePosition.y <= panBorderthickness)
        {
            currentPos.y -= camSpeed * Time.deltaTime;
        }
        if(Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderthickness)
        {
            currentPos.x += camSpeed * Time.deltaTime;
        }
        if(Input.GetKey("a") || Input.mousePosition.x <= panBorderthickness)
        {
            currentPos.x -= camSpeed * Time.deltaTime;
        }
       
        transform.position = currentPos;
    }
}
