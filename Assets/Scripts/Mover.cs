using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float xValue = 0f;
    [SerializeField]
    float yValue = 0f;
    [SerializeField]
    float zValue = 0f;

    public float moveSpeed = 1.5f;

    void Update()
    {
        xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        zValue = Input.GetAxis("Vertical") * moveSpeed  * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
