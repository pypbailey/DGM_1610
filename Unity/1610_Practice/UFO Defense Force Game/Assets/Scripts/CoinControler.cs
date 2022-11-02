using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControler : MonoBehaviour
{
   public GameObject coin; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Destroy(other.gameObject);
        }
    }
}
