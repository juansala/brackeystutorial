using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    // if object has a Rigidbody and a collider, this script will be called if assigned to it
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Debug.Log("Hit obstacle!");
            // Disables PlayerMovement script/class when hitting an object with tag obstacle.
            movement.enabled = false;
        }

    }
}
