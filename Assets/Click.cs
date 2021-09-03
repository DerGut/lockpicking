using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;


public class Click : MonoBehaviour
{

    float speed = 1f;
    public bool clicked = false;
    public bool moveslowly = false;
    public bool moved = false;
    Vector3 moveToPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveslowly)
        {
            transform.position = Vector3.Lerp(transform.position, moveToPosition, Time.deltaTime * speed);
        }
    }

    public void OnCancel()
    {
        print("Escape is hold down");
        moveslowly = true;
        moveToPosition = new Vector3(0f, 6f, -8f);
    }

    public void OnClick()
    {   
        clicked = true;

        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Door1")
                {
                    Debug.Log("Door1");
                    moveslowly = true;
                    moveToPosition = new Vector3(-15f, 3.5f, 14f);

                }
                else if (hitInfo.collider.gameObject.tag == "Door2")
                {
                    Debug.Log("Door2");
                    moveslowly = true;
                    moveToPosition = new Vector3(-7f, 3.5f, 14f);
                }

                else if (hitInfo.collider.gameObject.tag == "Door3")
                {
                    Debug.Log("Door3");
                    moveslowly = true;
                    moveToPosition = new Vector3(1f, 3.5f, 14f);

                }

                else if (hitInfo.collider.gameObject.tag == "Door4")
                {
                    Debug.Log("Door4");
                    moveslowly = true;
                    moveToPosition = new Vector3(9f, 3.5f, 14f);

                }

                else if (hitInfo.collider.gameObject.tag == "Door5")
                {
                    Debug.Log("Door5");
                    Application.Quit();

                }
            }
        }
        //Vector2 inputVec = input.Get<Vector2>();
        //moveVec = new Vector3(inputVec.x, 0, inputVec.y);
    }
        
}
