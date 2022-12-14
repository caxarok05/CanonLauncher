using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colider)
    {
        if (colider.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            ScoreScript._IsTargetDestroyed = true;
        }
    }


}
