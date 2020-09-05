using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal")) {
            vector.x = Input.GetAxis("Horizontal");
        }
        if (Input.GetButton("Vertical")) {
            vector.z = Input.GetAxis("Vertical");
        }
        transform.Translate(vector * speed * Time.deltaTime);
        vector.x = 0.0f;
        vector.z = 0.0f;
        vector.y = 0.0f;
    }
}
