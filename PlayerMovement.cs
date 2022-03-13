using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float TurnSpeed = 120.0f;
    public float MoveSpeed = 8.0f;

    public Transform target;
    public float smoothTime = 0.1F;
    private Vector3 velocity = Vector3.zero;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (FigmentInput.GetButton(FigmentInput.FigmentButton.LeftButton))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        }*/

        if (FigmentInput.GetButton(FigmentInput.FigmentButton.LeftButton))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        }
        else if (FigmentInput.GetButton(FigmentInput.FigmentButton.RightButton))
        {

            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
            //transform.position = Vector3.SmoothDamp(Vector2.one, Vector3.right, ref velocity, smoothTime);
            /* Vector3 targetPosition = target.TransformPoint(new Vector3(5, 0, 0));
             transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
             //Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            */
            //Vector2.SmoothDamp(v2Speed, Vector2.right, ref vel, 8.0f, smoothTime);

        }

        /*if (FigmentInput.GetButton(FigmentInput.FigmentButton.ActionButton))
        {
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);


        }*/
    }
}
