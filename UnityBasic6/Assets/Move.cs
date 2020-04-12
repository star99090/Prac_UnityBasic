using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 0.5f, 0);

    void Update()
    {
        //1.MoveTowards(등속 이동, 매개변수는 (현재위치,목표위치,속도)
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 0.1f);
        */

        //2.SmoothDamp(감속이동 (현재위치, 목표위치, 참조속도, 속도)
        /*
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.3f);
        */

        //3.Lerp(선형 보간, SmoothDamp보다 감속시간이 김, 마지막 매개변수는 속도이며 최대값1
        /*//선형 보간 : 물체를 순간이동 시키는 것이 아닌 움직임을 천천히 보이면서 이동하는 기법
        transform.position =
            Vector3.Lerp(transform.position, target, 0.03f);
        */

        //4.Slerp(구면 선형 보간, 호를 그리며 이동)
        transform.position =
            Vector3.Slerp(transform.position, target, 0.03f);



    }
}
