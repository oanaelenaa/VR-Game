using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverPannel;
    public bool isGameOver = false;

    void Awake()
    {
        gameOverPannel = GetComponentInParent<GameObject>();
        gameOverPannel.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverPannel.SetActive(true);
        }

    }
}
