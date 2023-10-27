using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePipe : MonoBehaviour
{
    public GameObject prefabToSpawn; // 생성할 Prefab을 저장할 변수
    public Transform spawnPoint; // 생성 위치를 저장할 변수

    private float spawnInterval = 3f; // 생성 간격 (3초)

    void Start()
    {
        // 지정된 간격으로 SpawnObject 메서드를 반복 호출
        InvokeRepeating("SpawnObject", 3f, spawnInterval);
    }

    void SpawnObject()
    {
        // spawnPoint 위치에 prefabToSpawn을 생성
        Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
