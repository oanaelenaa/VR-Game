using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorAction : MonoBehaviour {

    public Camera player;
    public Rigidbody rigidbody;
    // Use this for initialization

    void Start () {
        //   layer = GameObject.Find("Player");
        rigidbody = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
 
        if ((player.transform.position - this.transform.position).sqrMagnitude < 3 * 3)
        {
            print("close");
            // the player is within a radius of 3 units to this game object
        }
    }

}
