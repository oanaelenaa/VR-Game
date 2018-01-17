using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float speed;
    //private bool canJump;
    public Rigidbody rigidbody;
    public float jumpHeight;
    public Camera player;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void LateUpdate()
    {
        float moveHorizontal = 10.1f;
        float moveVertical = 10.1f;

        var lookposition = player.transform.position - rigidbody.transform.position;
        lookposition.y = 0;
        var rotation = Quaternion.LookRotation(lookposition);

        rigidbody.transform.rotation = Quaternion.Slerp(rigidbody.transform.rotation, rotation, Time.deltaTime * 2);

        rigidbody.transform.position = Vector3.MoveTowards(new Vector3(rigidbody.transform.position.x, 0.5f, rigidbody.transform.position.z), new Vector3(player.transform.position.x, 0.5f, player.transform.position.z), speed * Time.deltaTime);



        //rigidbody.MovePosition(Vector3.MoveTowards(new Vector3(rigidbody.transform.position.x, 100f, rigidbody.transform.position.z), new Vector3(player.transform.position.x, 100f, player.transform.position.z), speed * Time.deltaTime));

//        rigidbody.AddForce(Vector3.MoveTowards(new Vector3(rigidbody.transform.position.x, 100f, rigidbody.transform.position.z), new Vector3(player.transform.position.x, 100f, player.transform.position.z), speed * Time.deltaTime));

        //rigidbody.transform.position = Vector3.MoveTowards(rigidbody.transform.position, player.transform.position, speed * Time.deltaTime);



        //rigidbody.transform.position = (rigidbody.position - player.transform.position) / speed;

        //var camera = player.transform.position;

        //var mummy = rigidbody.position;

        //mummy.z = camera.z + 10;



        //rigidbody.transform.Translate(new Vector3(speed * mummy.x/10000, speed * mummy.y / 10000, speed * mummy.z / 10000));
        

        //var movement = new Vector3(0, 5f, 0);

        //rigidbody.AddForce(movement * speed);
    }
}
