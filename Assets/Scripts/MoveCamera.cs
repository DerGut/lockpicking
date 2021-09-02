using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    float speed = 1f;
    public bool moveslowly = false;
    Vector3 moveToPosition;
    void Start()
    {


    }


    void Update()
    {
        if(moveslowly)
        {
            transform.position = Vector3.Lerp(transform.position, moveToPosition, Time.deltaTime * speed);

        }

        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Door1") 
                {
                    Debug.Log("Door1");
                    moveslowly = true;
                    moveToPosition = new Vector3(-15f, 3.5f, 14f);
                    
                }
                else if(hitInfo.collider.gameObject.tag == "Door2")
                {
                    Debug.Log("Door2");
                    moveslowly = true;
                    moveToPosition = new Vector3(-7f, 3.5f, 14f);
                }

                else if(hitInfo.collider.gameObject.tag == "Door3") 
                {
                    Debug.Log("Door3");
                    moveslowly = true;
                    moveToPosition = new Vector3(1f, 3.5f, 14f);

                }

                else if(hitInfo.collider.gameObject.tag == "Door4") 
                {
                    Debug.Log("Door4");
                    moveslowly = true;
                    moveToPosition = new Vector3(9f, 3.5f, 14f);

                }

                else if(hitInfo.collider.gameObject.tag == "Door5") 
                {
                    Debug.Log("Door5");
                    Application.Quit();

                }
            }
        }
    }
    
    void move()
    {
        moveToPosition = new Vector3(-15f, 3.5f, 14f);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position, moveToPosition, step);
    }

}