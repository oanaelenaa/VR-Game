using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float speed;
    //private bool canJump;
    public Rigidbody rigidbody;
    public float jumpHeight;
    public Camera player;

    public PlayerHealth playerHealth;
    Animator anim;

    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        /* if (Input.GetKeyUp(KeyCode.Escape))
         {
             Application.Quit();
         }*/
      /*  if (playerHealth.g <= 0)
        {
            // ... tell the animator the game is over.
            anim.SetTrigger("GameOver");

        }/*/
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
    void OnCollisionEnter(Collision col)
    {
        //The other objects is tagged as player
        // Instantiate(textObject, Vector3(.5, .5, 0.0), Quaternion.identity);
        //  Application.Quit();
     //   var cam = Camera.main;
      //  if(c)
        print("collisioeeeeeeen");
      ///  Destroy(gameObject);
        // Destroy(gameObject);
    }
    void OnTriggerEnter(Collider c)
    {
        if (c == player)
        {
            print("OnTriggerEnter");
           // Destroy(gameObject);
            //game over

        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("OnTriggerEnter");
        float pushPower = 2.0F;
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
            return;

        if (hit.moveDirection.y < -0.3F)
            return;

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
    }

}
