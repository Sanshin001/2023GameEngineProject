using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false; // ���� �Ͻ����� ���¸� �����ϴ� ����

    void Update()
    {
        // ���� ������Ʈ�� �Ͻ�����/�簳�ϱ� ���� Ư�� Ű(��: 'P')�� �Է����� �޽��ϴ�.
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame(); // �Ͻ����� ���¿��� 'P'�� ������ ������ �簳�մϴ�.
            }
            else
            {
                PauseGame(); // �Ͻ����� ���°� �ƴ� �� 'P'�� ������ ������ �Ͻ������մϴ�.
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

    }

    void PauseGame()
    {
        Time.timeScale = 0f; // ��� ���� ������Ʈ�� ����ϴ�.
        isPaused = true;
        // ���⿡ ���� �Ͻ����� �� ������ �۾��� �߰��� �� �ֽ��ϴ�.
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // ��� ���� ������Ʈ�� �簳�մϴ�.
        isPaused = false;
        // ���⿡ ���� �簳 �� ������ �۾��� �߰��� �� �ֽ��ϴ�.
    }

    private void RestartGame()
    {
        // ���� ���� �ٽ� �ε��Ͽ� ������ ������մϴ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; // ���� �ӵ��� �������� �����ϴ�.
        // ���⿡ ������ ������� �� �ʱ�ȭ�ؾ� �ϴ� ���� �� ������Ʈ���� �ʱ�ȭ�� �� �ֽ��ϴ�.
    }
}
