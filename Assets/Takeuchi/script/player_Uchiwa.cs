using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Uchiwa : MonoBehaviour
{
    List<Rigidbody> rigidbodies = new List<Rigidbody>();



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (var rigidbody in rigidbodies)
            {
                rigidbody.AddForce(0, 100, 0);
            }
        }
        
            
            
        

        // Camera.main でメインカメラ（MainCamera タグの付いた Camera）を取得する
        // Camera.ScreenToWorldPoint 関数で、スクリーン座標をワールド座標に変換する
        Vector3 mousePosition = Input.mousePosition;
        // ターゲットが見えなくなってしまうため、Z 座標を調整している
        mousePosition.z = 10;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void OnTriggerEnter(Collider other)
    {
        rigidbodies.Add(other.gameObject.GetComponent<Rigidbody>());
    }
    private void OnTriggerExit(Collider other)
    {
        rigidbodies.Remove(other.gameObject.GetComponent<Rigidbody>());
    }
}
