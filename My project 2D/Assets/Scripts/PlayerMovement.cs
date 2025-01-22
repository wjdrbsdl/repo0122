using UnityEditor;
using UnityEngine;
//플레이어의 이동(리지드바디)

[RequireComponent(typeof(Rigidbody2D))] //해당 컴포넌트를 달면 저절로 rigidBody 할당
public class PlayerMovement : MonoBehaviour
{
    //이동을 하려면 - 이동 속도와 방향이 필요하다. 
    public float speed = 2.1f; //소수점 은 마지막 f
    public double jump_force = 3.5; //double도 실수 자료형인데 f가 필요없음.

    public bool isJump = false;
    private Rigidbody2D rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //GetComponet<T> //제네릭
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        //가로와 세로로 움직임 - 벡터 x, y
        float x = Input.GetAxisRaw("Horizontal"); //수평 - a,d, ←, →
        float y = Input.GetAxisRaw("Vertical"); //수직 - w,s, ↑, ↓

        //2D는 vector2지만 z 0이면 같기 때문에 3으로 계산, 3d로 발전된 에 너무 많다. 

        Vector3 velocity = new Vector3(x, y, 0) * speed * Time.deltaTime;
        //움직일 방향 택함
        //속력 = 속도 * 방향
        transform.position += velocity;
    }

    private void Jump()
    {
        //플레이어가 space 키를 입력했다면
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isJump == false)
            {
                isJump = true;
                //force - 지속, inpulse 순간적
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse);
               // Debug.Log("점프");
            }
       
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Debug.Log("골인");
        }
        else if (collision.gameObject.tag == "JumpPower")
        {
            jump_force += 1;
            Debug.Log("파워업"+jump_force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Layer는 계층 번호로 
        
        if(collision.gameObject.layer == 7)
        {
            isJump = false;
            Debug.Log("땅에 닿았음");
        }
    }
}
