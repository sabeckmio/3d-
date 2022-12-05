using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove: MonoBehaviour
{
    public int hp = 20; //�÷��̾� ü�� ����
    public GameObject hitEffect;

    // Start is called before the first frame update
    int maxHp = 20; //�ִ� ü�� ����

    public Slider hpSlider;
    public float moveSpeed= 7f;
    float gravity = -20f;

    float yVelocity = 0;
    public float jumpPower = 10f;
    CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;
        dir = Camera.main.transform.TransformDirection(dir);
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);
       if( Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
        }
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);
        hpSlider.value = (float)hp / (float)maxHp;
    }
    //�÷��̾� �ǰ��Լ�
    public void DamageAction(int damage)
    {
        // ���ʹ��� ���ݷ¸�ŭ �÷��̾��� ü���� ��´�.
        hp -= damage;
        if (hp > 0)
        {
            StartCoroutine(PlayHitEffect());
        }

    }
        //�İ�ȿ�� �ڷ�ƾ �Լ�
        IEnumerator PlayHitEffect()
        {
            //�İ� uiȰ��
            hitEffect.SetActive(true);

            //2. 0.3�ʰ� ���
            yield return new WaitForSeconds(0.3f);

            //3.�İ� ui�� ��Ȱ��ȭ
            hitEffect.SetActive(false);

        }
        
}
