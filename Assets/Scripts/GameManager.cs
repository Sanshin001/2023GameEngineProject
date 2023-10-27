using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false; // 게임 일시정지 상태를 저장하는 변수

    void Update()
    {
        // 게임 오브젝트를 일시정지/재개하기 위해 특정 키(예: 'P')를 입력으로 받습니다.
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame(); // 일시정지 상태에서 'P'를 누르면 게임을 재개합니다.
            }
            else
            {
                PauseGame(); // 일시정지 상태가 아닐 때 'P'를 누르면 게임을 일시정지합니다.
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

    }

    void PauseGame()
    {
        Time.timeScale = 0f; // 모든 게임 오브젝트를 멈춥니다.
        isPaused = true;
        // 여기에 게임 일시정지 시 수행할 작업을 추가할 수 있습니다.
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // 모든 게임 오브젝트를 재개합니다.
        isPaused = false;
        // 여기에 게임 재개 시 수행할 작업을 추가할 수 있습니다.
    }

    private void RestartGame()
    {
        // 현재 씬을 다시 로드하여 게임을 재시작합니다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; // 게임 속도를 정상으로 돌립니다.
        // 여기에 게임을 재시작할 때 초기화해야 하는 변수 및 컴포넌트들을 초기화할 수 있습니다.
    }
}
