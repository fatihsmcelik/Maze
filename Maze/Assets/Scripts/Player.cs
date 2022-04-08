using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

CharacterController cc;
public float speed = 10f;
float ySpeed = 0;
float gravity = -10f;
public Transform cam ;
float pitch = 0f;  
public static float timer;


public static bool start;

    // Start is called before the first frame update
    void Start()
    {
        start = true;
        timer =0;
        cc = GetComponent<CharacterController>();
    }
      void StopwatchCal(){
          if(start){
            timer+=Time.deltaTime;
            
            
          }
        
    }

    // Update is called once per frame
    void Update()
    {
        StopwatchCal();
        float xInput = Input.GetAxis("Horizontal")*speed; 
        float zInput = Input.GetAxis("Vertical")*speed;

        Vector3 move = new Vector3(xInput,0,zInput);
        move = Vector3.ClampMagnitude(move,speed);
        move = transform.TransformVector(move);

    if(cc.isGrounded)
    {
        if(Input.GetButtonDown("Jump"))
        {
            ySpeed = 10f;
        }
        else
        {
           // ySpeed=0f;
            ySpeed = gravity * Time.deltaTime;
        }
    }
    else
    {
        ySpeed+= gravity*Time.deltaTime;
    }
    Debug.Log(ySpeed);

        cc.Move((move + new Vector3(0,ySpeed,0))*Time.deltaTime);

        float xMouse = Input.GetAxis("Mouse X")*10f;
        transform.Rotate(0,xMouse,0);

        pitch -= Input.GetAxis("Mouse Y")*10f;
        pitch = Mathf.Clamp(pitch,-33f,33f);
        Quaternion camRotation = Quaternion.Euler(pitch,0,0);
        cam.localRotation = camRotation;
    }
}
