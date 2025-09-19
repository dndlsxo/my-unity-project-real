using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    [HideInInspector] public Vector2 lastMoveDirection = Vector2.right; // 처음엔 오른쪽

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, v).normalized;

        if (dir != Vector2.zero)
        {
            lastMoveDirection = dir;
            transform.Translate(dir * moveSpeed * Time.deltaTime);
        }
    }
}
