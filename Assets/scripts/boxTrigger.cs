using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTrigger : MonoBehaviour

{
    public int score = 0;
    void OnTriggerEnter(Collider mendy)
    {
        if (mendy.gameObject.tag == "Coin")
        {
            score++;
            Destroy(mendy.gameObject);
        
        }
        Debug.Log(score);
    }
}
