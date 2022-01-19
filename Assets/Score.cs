using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Move the ball
    // Manage the score

    public GameObject ball;
    int score = 0;
    GameObject[] bottles;

    // Start is called before the first frame update
    void Start()
    {
        bottles = GameObject.FindGameObjectsWithTag("Bottle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || ball.transform.position.y < 20)
            CountBottlesDown();
    }
    
    void CountBottlesDown()
    {
        for(int i = 0; i < bottles.Length; i++)
        {
            if(bottles[i].transform.eulerAngles.z > 5 && bottles[i].transform.eulerAngles.z < 355)
            {
                score++;
            }
        }

        Debug.Log(score);
    }
}
