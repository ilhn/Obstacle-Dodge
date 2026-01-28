using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;
    void Start()
    {
        yAngle = 1f;
    }
    void Update()
    {
        transform.Rotate(0,yAngle,0);
    }
}
