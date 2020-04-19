using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
        
    }
    //이벤트 함수 만들때는 보통 앞에 On을 붙인다, Collision : 충돌 정보 클래스
    private void OnCollisionEnter(Collision collision) // 물리적 충돌이 시작할 때 호출되는 함수
    {
        if(collision.gameObject.name == "MyBall") 
            mat.color = new Color(0, 0, 0); // Color32로 하면 255가지 그림판 그 색상 나옴 ㅎ
    }

    /*
    private void OnCollisionStay(Collision collision) // 물리적 충돌이 진행되는 중
    {

    }
    */

    private void OnCollisionExit(Collision collision) // 물리적 충돌이 끝났을 때 호출되는 함수
    {
        if (collision.gameObject.name == "MyBall")
            mat.color = new Color(1, 1, 1);
    }
    
}
