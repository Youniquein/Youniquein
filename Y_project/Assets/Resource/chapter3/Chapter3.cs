using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    float rotSpeed = 0;  // 회전 속도   

    void Start()
    {
        // 프레임레이트를 60으로 고정한다
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 클릭하면 회전 속도를 설정한다
        if (Input.GetMouseButtonDown(0)) // 마우스를 "눌렀을 때" 실행
        {
            this.rotSpeed = 10;
        }

        // 축을 기준으로 rotSpeed만큼 룰렛을 회전시킨다
        transform.Rotate(0, 0, this.rotSpeed);

        // 도는 속도가 0.1f보다 작아지면 강제적으로 속도를 0으로 맞춤
        if (rotSpeed < 0.1f)
        {
            rotSpeed = 0;
        }
        else
        {
            // 룰렛을 감속시킨다
            this.rotSpeed *= 0.99f;
        }
    }
}
