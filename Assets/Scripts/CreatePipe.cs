using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePipe : MonoBehaviour
{
    public GameObject prefabToSpawn; // ������ Prefab�� ������ ����
    public Transform spawnPoint; // ���� ��ġ�� ������ ����

    private float spawnInterval = 3f; // ���� ���� (3��)

    void Start()
    {
        // ������ �������� SpawnObject �޼��带 �ݺ� ȣ��
        InvokeRepeating("SpawnObject", 3f, spawnInterval);
    }

    void SpawnObject()
    {
        // spawnPoint ��ġ�� prefabToSpawn�� ����
        Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
