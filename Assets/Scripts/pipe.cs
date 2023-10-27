using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float moveSpeed = 5f; // ������Ʈ �̵� �ӵ�
    public float destroyXPosition = -10f; // ������Ʈ�� ������� X ��ǥ

    void Update()
    {
        // ������Ʈ�� �������� �̵�
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // ������Ʈ�� ���� X ��ǥ�� Ư�� ������ ������ ������Ʈ �ı�
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
