using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Scripts : MonoBehaviour
{

    public GameObject Player;


    // Update is called once per frame
    void Update()
    {

        if (Player != null)
        {
            Vector3 position = transform.position;
            position.x = Player.transform.position.x;
            transform.position = position;
        }
        
    }
}
