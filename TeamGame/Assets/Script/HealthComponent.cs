using UnityEngine;


public class HealthComponent : MonoBehaviour
{
    [SerializeField] public int Health = 100; // начальное здоровье

    public void TakeDamage(int Damage)
    {
        Health -= Damage;
        Debug.Log($"health {Health}");
        if (Health <= 0)
        {
            Die();
            
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
