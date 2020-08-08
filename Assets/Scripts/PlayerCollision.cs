
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

  
    public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
