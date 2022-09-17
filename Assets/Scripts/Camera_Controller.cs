using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    public Transform ball;

    private Vector3 offset;
    public float smooth_Speed;


    void Start()
    {
        offset = transform.position - ball.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position,offset+ball.position,smooth_Speed);
        transform.position = newPos;
    }
}
