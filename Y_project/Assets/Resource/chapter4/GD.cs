using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GD : MonoBehaviour
{
    GameObject car; // "car"라는 "GameObject"를 담을 변수
    GameObject flag;
    GameObject distance;

    void Start()
    {
        // GameObject.Find("하이어라키에 "켜져있는" 오브젝트 이름);
        // 오브젝트들 중 이름으로 찾는 방법
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        // Start()에서 flag, car를 찾았음
        // gameObject.transform.position =
        //   그 오브젝트의 위치 정보(좌표값)을 받아옴
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
        // F2는 소수점 둘째자리까지만 보여준다는 뜻
    }
}
