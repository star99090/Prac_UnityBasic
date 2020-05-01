using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator ani;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
    }
    //Rigidbody2D에 z축 얼리는게 있는데 그거 해줘야 캐릭터가 안굴러간다
    void Update() // 단발적인, 한 번의 키 입력은 Update()
    {
        //이동 멈추는 속도 조절
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
                // normalized : 벡터의 크기를 1로 만들어버린 상태(+ - 부호는 그대로 유지해줌) 방향구할때 씀
            /* 키에서 손 떼면 바로 멈추는 소스코드
            rigid.velocity = new Vector2(0, rigid.velocity.y);
            */
        }

        //방향전환
        if (Input.GetButtonDown("Horizontal"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }

        //완전히 멈췄을 때
        if (Mathf.Abs(rigid.velocity.x) < 0.3)
            ani.SetBool("isWalking", false);
        else
            ani.SetBool("isWalking", true);
    }
    void FixedUpdate() // 지속적인 키 입력은 FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        //오른쪽 이동 Max Speed
        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        //왼쪽 이동 Max Speed
        else if (rigid.velocity.x < maxSpeed*(-1))
            rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
    }
}
