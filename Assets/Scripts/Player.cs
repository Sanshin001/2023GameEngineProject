using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f; // ������ ���� ���� ũ��

    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody2D ������Ʈ�� �����ɴϴ�.
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �����̽� �ٸ� ������ �� ������ �����մϴ�.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Rigidbody2D�� ���� �������� ���� ���� ������Ʈ�� ������ŵ�ϴ�.
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
