using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    
    void Start()
    {

    }
    
    void Update()
    {
        //int number = 4; 이런 단순한 값을 '스칼라' 라고 부른다. 그 값에 방향이 붙으면 벡터
        Vector3 vec = new Vector3( //Time.deltaTime : 이전 프레임의 완료까지 걸린 시간   
                                   //이걸 안하면 컴퓨터 사양에 따라 속도가 달라져서 꼭 해야함
                                   //게임 상에서 가능한, 최대한 사양에 구애받지 않고 진행되게 함
            Input.GetAxisRaw("Horizontal")*Time.deltaTime,
            Input.GetAxisRaw("Vertical")*Time.deltaTime,
            0); // x, y, z 값을 갖는 '벡터'
        transform.Translate(vec); // Translate : 벡터 값을 현재 위치에 더하는 함수(이동)
                                  // Vectror2 하면 2D, 3하면 3D
    }
    


    // void Update() // 게임 로직 업데이트, 환경에 따라 실행주기가 떨어질 수 있음
    // 내 노트북에선 이게 훨씬 빠름
    // {
    //if (Input.anyKeyDown) // 입력 1번
    //    Debug.Log("플레이어가 아무 키를 눌렀습니다.");

    /*
    if (Input.GetKeyDown(KeyCode.Return)) // Enter == Return / 원하는거 입력하면 가능
                                          // ESC = Escape, GetKeyDown : 눌렀을 때
        Debug.Log("아이템을 구입하였습니다.");

    if (Input.GetKey(KeyCode.LeftArrow)) // GetKey : 눌러져 있는 상태
        Debug.Log("왼쪽으로 이동 중");

    if (Input.GetKeyUp(KeyCode.RightArrow)) // GetKeyUp : 입력을 땠을 때
        Debug.Log("오른쪽으로 이동을 멈추었습니다.");
    */

    /*
    if (Input.GetMouseButtonDown(0)) // 0은 좌클릭, 1은 우클릭
        Debug.Log("미사일 발사!");

    if (Input.GetMouseButton(0))
        Debug.Log("미사일 모으는 중...");

    if (Input.GetMouseButtonUp(0))
        Debug.Log("슈퍼 미사일 발사!!");
    */

    /*
    // GetButton : Input 내용 받으면 true
    if (Input.GetButton("Horizontal"))
    {
        Debug.Log("횡 이동 중..."
            + Input.GetAxisRaw("Horizontal"));
        // GetAxis : 수평, 수직 버튼 입력받으면 float / 누르면 쭉~ 가속도 좀 붙음
        // GetAxisRaw : 무조건 1씩 값을 받게 함
    }

    if (Input.GetButton("Vertical"))
    {
        Debug.Log("종 이동 중..."
            + Input.GetAxisRaw("Vertical"));
    }
    */
    //  }
}