using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    float rotSpeed = 0;  // ȸ�� �ӵ�   

    void Start()
    {
        // �����ӷ���Ʈ�� 60���� �����Ѵ�
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ�
        if (Input.GetMouseButtonDown(0)) // ���콺�� "������ ��" ����
        {
            this.rotSpeed = 10;
        }

        // ���� �������� rotSpeed��ŭ �귿�� ȸ����Ų��
        transform.Rotate(0, 0, this.rotSpeed);

        // ���� �ӵ��� 0.1f���� �۾����� ���������� �ӵ��� 0���� ����
        if (rotSpeed < 0.1f)
        {
            rotSpeed = 0;
        }
        else
        {
            // �귿�� ���ӽ�Ų��
            this.rotSpeed *= 0.99f;
        }
    }
}
