using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FSPControlScript : MonoBehaviour {
    public GameObject gameOverPannel;
    public Text gameOverText;
    // Use this for initialization
    void Awake()
    {
        //gameOverPannel= GetComponentInParent<GameObject>();
        gameOverPannel.SetActive(false);
    }
	void Start () {

    }
	
    ///Checks if the camera collides with something
     void OnTriggerStay(Collider other)
    {
        //When colliding, the camera moves up and back from the player object          
        /// transform.position += new Vector3(0, 0.2f, -0.2f);
        print("camera collision");
    }
    // Update is called once per frame
    void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        //The other objects is tagged as player
        // Instantiate(textObject, Vector3(.5, .5, 0.0), Quaternion.identity);
        //  Application.Quit();
        //   var cam = Camera.main;
        //  if(c)
        print("collisioeeeeeeen");
        // Destroy(gameObject);
    }
    void OnTriggerEnter(Collider c)
    {
        print("in trigger fsp");
        if (c.gameObject.name== "mummy@jumpOnePiece" || c.gameObject.name == "mummy@attack" || c.gameObject.name == "mummy@die01" || c.gameObject.name == "mummy_rig")
        {
            print("on collision mummy");
            Application.Quit();
            //Destroy(gameObject);
            //Application.Quit();
            gameOverPannel.SetActive(true);
            gameObject.transform.position.Set(0, 0, 0);
            Destroy(gameObject);
            //game over
        }
        if(c.gameObject.name== "Door_Main1")
        {
            gameOverText.text = "You won";
            gameOverPannel.SetActive(true);
            Destroy(gameObject);
            //cange text UI TO "YOU WON!"
            //gameOverPannel.SetActive(true);
        }
    }
}
