using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GD : MonoBehaviour
{
    GameObject car; // "car"��� "GameObject"�� ���� ����
    GameObject flag;
    GameObject distance;

    void Start()
    {
        // GameObject.Find("���̾��Ű�� "�����ִ�" ������Ʈ �̸�);
        // ������Ʈ�� �� �̸����� ã�� ���
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        // Start()���� flag, car�� ã����
        // gameObject.transform.position =
        //   �� ������Ʈ�� ��ġ ����(��ǥ��)�� �޾ƿ�
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
        // F2�� �Ҽ��� ��°�ڸ������� �����شٴ� ��
    }
}
