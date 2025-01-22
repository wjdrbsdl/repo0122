using UnityEngine;

public enum RAINBOW
{
    ��,��,��,��,��,��,��
}

[AddComponentMenu("JG/Mission")]
public class Mission : MonoBehaviour
{
    public bool ableJump = false;

    public int fruitBasket;
    public int money;

    [Range(1,99)]
    public float fieldView;

    public RAINBOW rainbow;

}
