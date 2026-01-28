using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float transitionSpeed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;
    }
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached(gameObject);
    }
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, transitionSpeed * Time.deltaTime);
    }
    void DestroyWhenReached(GameObject obj)
    {
        if (transform.position == playerPosition)
            Destroy(obj);
    }
}
