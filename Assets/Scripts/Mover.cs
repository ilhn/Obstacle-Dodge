using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float xValue = 0f;
    [SerializeField]
    float yValue = 0f;
    [SerializeField]
    float zValue = 0f;

    void Update()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * Time.deltaTime, yValue * Time.deltaTime, zValue);
    }
}
