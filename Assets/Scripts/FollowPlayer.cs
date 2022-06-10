using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0f, 1f, -2f);
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        //transform.position = player.transform.position
        //transform.position = player.transform.position + new Vector3(0f, 9f, -13.5f);  *this is for follow player perfect using main camera position*
        transform.position = player.transform.position + offset;  // using variable 
    }
}
