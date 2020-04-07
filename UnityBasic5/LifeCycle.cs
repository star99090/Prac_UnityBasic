using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//초기화-(활성화)-물리-게임로직-(비활성화)-해체
//          └ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ┘

public class LifeCycle : MonoBehaviour
{
    void Awake() // 게임 오브젝트 생성할 때, 최초 실행 1번
    {
        Debug.Log("플레이의 데이터가 준비되었습니다.");
    }

    void OnEnable() // 게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start() // 업데이트 시작 직전, 최초 실행 1번
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() // 물리 연산 업데이트, 고정된 실행 주기(50/s)로 CPU 많이 사용
                               // = CPU 부하가 많이 생길 수 있다
    {
        Debug.Log("이동~");
    }

    void Update() // 게임 로직 업데이트, 환경에 따라 실행주기가 떨어질 수 있음
                  // 내 노트북에선 이게 훨씬 빠름
    {
        Debug.Log("몬스터 사냥!");
    }

    void LateUpdate() // 모든 업데이트 끝난 후, 로직의 후처리
                      // 카메라 이동이나 경험치 획득 등을 많이 넣는 편
    {
        Debug.Log("경험치 획득.");
    }

    void OnDisable() // 게임 오브젝트가 비활성화 되었을 때
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy() // 게임 오브젝트가 삭제되기 직전
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
