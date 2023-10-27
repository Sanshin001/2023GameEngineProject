using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float moveSpeed = 5f; // 오브젝트 이동 속도
    public float destroyXPosition = -10f; // 오브젝트가 사라지는 X 좌표

    void Update()
    {
        // 오브젝트를 왼쪽으로 이동
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // 오브젝트의 현재 X 좌표가 특정 값보다 작으면 오브젝트 파괴
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
