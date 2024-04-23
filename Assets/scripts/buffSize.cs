using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffSize : MonoBehaviour
{
    void OnTriggerEnter(Collider mendy)
    {
        if ((mendy.gameObject.tag == "Buff") && (transform.localScale.x < 2f ))
        {
            transform.localScale += new Vector3(0.1f,0.1f, 0.1f);
            Destroy(mendy.gameObject); 
        }  
    }
    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Obstacle") && (transform.localScale.x > 0.2f ))
        {
            transform.localScale -= new Vector3(0.1f,0.1f, 0.1f);
        }
    }
}
