using System;
using Unity.Profiling;
using UnityEngine;

[Flags]
public enum DAY
{
    None = 0,
    �� = 1 << 0,
    �� = 1 << 1,
    ȭ = 1 << 2,
    �� = 1 << 3,
    �� = 1 << 4,
    �� = 1 << 5,
    �� = 1 << 6
}

public enum JOB
{
    �丮��, ������, ��ȭ��, ������
}

public class DataExample : MonoBehaviour
{
    public string[] schedules; //�迭
    public DAY workDay;
    public JOB job;
    //������ ������ �� �ְ� ��� ���Ͽ� ���ϴ���

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
