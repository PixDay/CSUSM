using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject prefab;
    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x + Random.Range(-1.0f, 1.0f);
        y = transform.position.y + Random.Range(-1.0f, 1.0f);
        z = transform.position.z + Random.Range(-1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x + Random.Range(-1.0f, 1.0f);
        y = transform.position.y + Random.Range(-1.0f, 1.0f);
        z = transform.position.z + Random.Range(-1.0f, 1.0f);
        
        if (Input.GetButtonDown("Jump")) {
            Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}
