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

    void Start()
    {
        PrintInstruction();
    }
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or W-A-S-D keys");
    }

    void MovePlayer()
    {
        xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        zValue = Input.GetAxis("Vertical") * moveSpeed  * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
