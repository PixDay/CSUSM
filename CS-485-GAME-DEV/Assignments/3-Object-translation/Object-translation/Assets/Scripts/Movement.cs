using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 vector;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        vector.x = Random.Range(-20.0f, 20.0f);
        vector.z = Random.Range(-20.0f, 20.0f);
        vector.y = 0.0f;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(vector * Time.deltaTime);
    }
}
