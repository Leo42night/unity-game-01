using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;
    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle"){
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
