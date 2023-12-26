using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이게 주석 한줄이다.

/*
 * 이게 주석 여러
 * 줄
 * 이
 * 다.
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
        Debug.Log("으악졸려");
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

    void Awake() // 얘가 스타트보다 빨리 1회 실행
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

    void OnEnable() // 이 스크립트를 가진(컴포넌트로 달린)
                    // 오브젝트가 활성화 될 때
    {
        Debug.Log("켜졌다.");
    }

    void OnDisable()
    {
        Debug.Log("꺼졌다.");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
    }
}