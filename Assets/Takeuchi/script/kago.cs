using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class kago : MonoBehaviour
{

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            Destroy(gameObject);
        }
     
    }
}
