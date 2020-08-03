using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 5f, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -5f, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-5f, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(5f, 0, 0) * Time.deltaTime);
        }

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -15, 15);
        position.z = Mathf.Clamp(position.z, -11.18f, -11.18f);
        position.y = Mathf.Clamp(position.y, 3, 10);

        transform.position = position;
    }

}

