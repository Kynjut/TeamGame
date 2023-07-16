using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    [SerializeField] public int Damage = 50;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthComponent healthSystem = collision.gameObject.GetComponent<HealthComponent>();
        if (healthSystem != null)
        {
            healthSystem.TakeDamage(Damage);
        }
    }
}
