using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // 적 삭제
            Destroy(gameObject);       // 투사체 삭제
        }
    }
}
