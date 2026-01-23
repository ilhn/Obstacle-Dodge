using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitScore = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hitScore++;
            Debug.Log("Hitscore is: " + hitScore);
        }
    }
}
