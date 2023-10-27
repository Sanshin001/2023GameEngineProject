using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // ��� ��ũ�� �ӵ�
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed; // �ð��� ���� offset�� ����մϴ�.
        Vector2 offsetVector = new Vector2(offset, 0);
        meshRenderer.material.mainTextureOffset = offsetVector; // Mesh Renderer�� offset�� �����մϴ�.
    }
}
