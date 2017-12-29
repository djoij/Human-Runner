using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public GameObject player;
    float offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position.x - player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 pos = transform.position;
            pos.x = player.transform.position.x + offset;
            transform.position = pos;
    }

    // Update is called once per frame
    //void Update () {
		
	//}
}
