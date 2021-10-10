using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
        // 'transform' refers to current object transform
        transform.position = player.position + offset;
    }
}
