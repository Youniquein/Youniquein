using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �̰� �ּ� �����̴�.

/*
 * �̰� �ּ� ����
 * ��
 * ��
 * ��.
 */

public class Study_01 : MonoBehaviour
{
    // int test = 1;
    // lua = nil
    // C# = null

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

        /*Debug.Log(test); // 1
        test++;
        Debug.Log(test);
        test += 1;
        Debug.Log(test);
        test = test + 1;
        Debug.Log(test);*/
    }

    void OnDestroy()
    {
        Debug.Log("��������");
    }

    void OnApplicationPause(bool pause)
    {
        
    }

    void OnApplicationQuit()
    {
        
    }

    void OnApplicationFocus(bool focus)
    {
        
    }

    void Awake() // �갡 ��ŸƮ���� ���� 1ȸ ����
    {
        Debug.LogError("Awake");
    }

    void FixedUpdate()
    {
        // Debug.LogWarning("FixedUpdate");
    }

    void LateUpdate()
    {
        // Debug.LogError("LateUpdate");
    }

    void OnEnable() // �� ��ũ��Ʈ�� ����(������Ʈ�� �޸�)
                    // ������Ʈ�� Ȱ��ȭ �� ��
    {
        Debug.Log("������.");
    }

    void OnDisable()
    {
        Debug.Log("������.");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
    }
}