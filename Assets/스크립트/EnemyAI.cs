using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Transform player;
    public float speed = 3f;

    void Start()
    {
        // "Player" 태그가 붙은 오브젝트 찾기
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            Vector2 dir = (player.position - transform.position).normalized;
            transform.Translate(dir * speed * Time.deltaTime);
        }
    }
}
