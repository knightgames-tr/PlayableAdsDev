using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTrigger : MonoBehaviour
{

    public StairController _stair;
    void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "Player"){
            _stair.addToStairQueue(other.transform);
        }
    }
}
