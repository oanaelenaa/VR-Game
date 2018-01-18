using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheeep : MonoBehaviour {

    public Rigidbody rigidbody;
    public float speed;
    public float direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LateUpdate()
    {
        float moveHorizontal = 10.1f;
        float moveVertical = 10.1f;

        //var lookposition = player.transform.position - rigidbody.transform.position;
        //lookposition.y = 0;
        //var rotation = Quaternion.LookRotation(lookposition);

        //rigidbody.transform.rotation = Quaternion.Slerp(rigidbody.transform.rotation, rotation, Time.deltaTime * 2);

        //int direction = 1;

        //if (rigidbody.transform.position.z > 22.5)
        //{
        //    direction = -1;
        //}
        if (rigidbody.transform.position.z < 3.7)
        {
            direction *= -1;
        }

        if (rigidbody.transform.position.z > 22.5)
        {
            direction *= -1;
        }

        //if (rigidbody.transform.position.z > 3.87 && rigidbody.transform.position.z < 22.5)
        //{
        //    direction = 1;
        //}
        //else {
        //    direction = -1;
        //}
        rigidbody.transform.position = Vector3.MoveTowards(new Vector3(rigidbody.transform.position.x, 0.5f, rigidbody.transform.position.z), new Vector3(rigidbody.transform.position.x, 0.5f, (rigidbody.transform.position.z + 10) * direction), speed * Time.deltaTime);
        //{
        //    rigidbody.transform.position = Vector3.MoveTowards(new Vector3(rigidbody.transform.position.x, 0.5f, rigidbody.transform.position.z), new Vector3(rigidbody.transform.position.x, 0.5f, rigidbody.transform.position.z + 10), speed * Time.deltaTime);
        //}
        //else
        //{
        //    rigidbody.transform.position = Vector3.MoveTowards(new Vector3(rigidbody.transform.position.x, 0.5f, rigidbody.transform.position.z), new Vector3(rigidbody.transform.position.x, 0.5f, rigidbody.transform.position.z - 10), speed * Time.deltaTime);
        //}



    }
}
