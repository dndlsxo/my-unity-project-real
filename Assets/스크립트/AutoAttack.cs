using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 20f;

    void Update()
    {
        // 마우스 왼쪽 버튼 클릭 시 발사
        if (Input.GetMouseButtonDown(0))
        {
            // 1. 마우스 위치를 월드 좌표로 변환
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0f;

            // 2. 플레이어 위치에서 마우스 위치까지의 방향 벡터 계산
            Vector2 shootDir = (mouseWorldPos - transform.position).normalized;

            // 3. 투사체 생성
            GameObject proj = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // 4. 투사체에 방향과 속도 전달
            Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = shootDir * projectileSpeed;
            }

            // (선택) 투사체가 방향을 바라보게 회전
            float angle = Mathf.Atan2(shootDir.y, shootDir.x) * Mathf.Rad2Deg;
            proj.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
