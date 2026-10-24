using UnityEngine;

public class Object: MonoBehaviour
{
    [SerializeField] private float amountPoints;

    [SerializeField] private Score score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            score.AddScore(amountPoints);
            
            Destroy(gameObject);
            // Handle collision with player
        }
    }
}
