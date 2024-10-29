using System;
using UnityEngine;

public class Mathf : MonoBehaviour
{
    void Start()
    {
        // Mathf.Abs() 함수
        // 1. 절대 값 - 데이터의 절대값 반환
        Debug.Log("Math.Abs() : " + Math.Abs(-10.5));

        // Mathf.Max(), Mathf.Min() 
        // 2. 최대 최소 - a와 b를 비교해 최대 / 최소 값을 구함
        int a = 10, b = 20;
        Debug.Log("Math.Max() : " + Math.Max(a, b));
        Debug.Log("Math.Min() : " + Math.Min(a, b));
    }
}
