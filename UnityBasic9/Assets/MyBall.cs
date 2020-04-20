using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
   
    void Start()
    {
        rigid = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {   /*
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); //2. 힘을 줘서 움직이기
            //ForceMode : 힘을 주는 방식
            //캐릭터 점프는 보통 rigid.AddForce(Vector3.Up * 5, ForceMode.Impulse) 이거로 씀
            //Mass(무게)의 영향을 받는다.
        }
        */
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse); //이게 있어야 rigid에 힘이 추가되는 듯
        //rigid.velocity = new Vector3(2,4,3); //1. 속력 바꾸기
        //Update()에서 호출하면 계속 이동함(로켓 마냥) velocity : 현재 이동속도
        //물리현상 내용은 FixUpdate에 쓰도록 권장
        

        //3. 회전력 : Vec 방향을 '축'으로 회전력이 생김
        //rigid.AddTorque(Vector3.down);
    }

    private void OnTriggerStay(Collider other) // 콜라이더가 계속 충돌하고 있을 때 호출
    {
        if(other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
    /*
//실제 물리적인 충돌로 발생하는 이벤트
void OnCollisionEnter(Collision collision) { }
void OnCollisionStay(Collision collision) { }
void OnCollisionExit(Collision collision) { }

//콜라이더 충돌로 발생하는 이벤트
void OnTriggerEnter(Collider other) { }
void OnTriggerStya(Collider other) { }
void OnTriggerExit(Collider other) { }
*/
}

