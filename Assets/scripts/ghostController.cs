using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ghostController : MonoBehaviour
{
    public int speed = 5;
    private float horizontal;
    private float vertical;
    private int rotationSpeed =  100;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.T)){
            transform.rotation = Quaternion.identity;
            transform.Translate(Vector3.up * 0.01f);
        }
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);
    }
}
