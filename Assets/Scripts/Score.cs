using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;/* responsible for rotation and position skills */
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");/* without 
                                                          * comma seperation*/


    }
}
