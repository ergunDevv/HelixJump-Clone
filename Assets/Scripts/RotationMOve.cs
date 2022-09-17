 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMOve : MonoBehaviour
{
    public float rotate_Speed;
    private float move_X;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move_X = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, move_X * rotate_Speed * Time.deltaTime, 0f);
        }
    }
}
