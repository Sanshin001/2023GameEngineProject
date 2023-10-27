using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f; // 점프에 사용될 힘의 크기

    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody2D 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 바를 눌렀을 때 점프를 수행합니다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Rigidbody2D에 위쪽 방향으로 힘을 가해 오브젝트를 점프시킵니다.
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
