using UnityEditor;
using UnityEngine;
//�÷��̾��� �̵�(������ٵ�)

[RequireComponent(typeof(Rigidbody2D))] //�ش� ������Ʈ�� �޸� ������ rigidBody �Ҵ�
public class PlayerMovement : MonoBehaviour
{
    //�̵��� �Ϸ��� - �̵� �ӵ��� ������ �ʿ��ϴ�. 
    public float speed = 2.1f; //�Ҽ��� �� ������ f
    public double jump_force = 3.5; //double�� �Ǽ� �ڷ����ε� f�� �ʿ����.

    public bool isJump = false;
    private Rigidbody2D rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //GetComponet<T> //���׸�
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        //���ο� ���η� ������ - ���� x, y
        float x = Input.GetAxisRaw("Horizontal"); //���� - a,d, ��, ��
        float y = Input.GetAxisRaw("Vertical"); //���� - w,s, ��, ��

        //2D�� vector2���� z 0�̸� ���� ������ 3���� ���, 3d�� ������ �� �ʹ� ����. 

        Vector3 velocity = new Vector3(x, y, 0) * speed * Time.deltaTime;
        //������ ���� ����
        //�ӷ� = �ӵ� * ����
        transform.position += velocity;
    }

    private void Jump()
    {
        //�÷��̾ space Ű�� �Է��ߴٸ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isJump == false)
            {
                isJump = true;
                //force - ����, inpulse ������
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse);
               // Debug.Log("����");
            }
       
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Debug.Log("����");
        }
        else if (collision.gameObject.tag == "JumpPower")
        {
            jump_force += 1;
            Debug.Log("�Ŀ���"+jump_force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Layer�� ���� ��ȣ�� 
        
        if(collision.gameObject.layer == 7)
        {
            isJump = false;
            Debug.Log("���� �����");
        }
    }
}
