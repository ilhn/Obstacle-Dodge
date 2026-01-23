using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitScore = 0;
    void OnCollisionEnter(Collision other)
    {
        hitScore++;
        Debug.Log("You have bumped into a thing this many times: " + hitScore);
    }
}
