using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    Vector3 moveVector = new Vector3(1, 0, 0);
    public int speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveVector * speed * Time.deltaTime);
        Vector3 rot = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x <= -3.0f)
        {
            transform.rotation = Quaternion.Euler(rot);
        }

        if (transform.position.x >= 3.0f)
        {
            transform.rotation = Quaternion.Euler(rot);
        }
    }
}
    