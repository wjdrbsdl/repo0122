using System;
using Unity.Profiling;
using UnityEngine;

[Flags]
public enum DAY
{
    None = 0,
    일 = 1 << 0,
    월 = 1 << 1,
    화 = 1 << 2,
    수 = 1 << 3,
    목 = 1 << 4,
    금 = 1 << 5,
    토 = 1 << 6
}

public enum JOB
{
    요리사, 제빵사, 미화원, 정원사
}

public class DataExample : MonoBehaviour
{
    public string[] schedules; //배열
    public DAY workDay;
    public JOB job;
    //스케쥴 저장할 수 있고 어느 요일에 일하는지

    private void Start()
    {
        for (int i = 0; i < schedules.Length; i++)
        {
            Debug.Log(schedules[i]);
        }

        Debug.Log((int)workDay);
        Debug.Log(job);
    }
}
