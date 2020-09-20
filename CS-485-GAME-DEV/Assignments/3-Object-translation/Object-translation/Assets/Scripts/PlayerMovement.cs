using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 vector;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
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
        rigidbody.AddForce(vector * speed * Time.deltaTime);
        vector.x = 0.0f;
        vector.z = 0.0f;
        vector.y = 0.0f;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "CollidedSphere")
            Destroy(collision.collider.gameObject);
    }
}
