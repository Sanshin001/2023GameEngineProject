using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // 배경 스크롤 속도
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed; // 시간에 따라 offset을 계산합니다.
        Vector2 offsetVector = new Vector2(offset, 0);
        meshRenderer.material.mainTextureOffset = offsetVector; // Mesh Renderer의 offset을 설정합니다.
    }
}
