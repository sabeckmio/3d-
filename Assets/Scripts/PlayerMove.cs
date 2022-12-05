using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove: MonoBehaviour
{
    public int hp = 20; //플레이어 체력 변수
    public GameObject hitEffect;

    // Start is called before the first frame update
    int maxHp = 20; //최대 체력 변수

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
    //플레이어 피격함수
    public void DamageAction(int damage)
    {
        // 에너미의 공격력만큼 플레이어의 체력을 깎는다.
        hp -= damage;
        if (hp > 0)
        {
            StartCoroutine(PlayHitEffect());
        }

    }
        //파격효과 코루틴 함수
        IEnumerator PlayHitEffect()
        {
            //파격 ui활성
            hitEffect.SetActive(true);

            //2. 0.3초간 대기
            yield return new WaitForSeconds(0.3f);

            //3.파격 ui를 비활성화
            hitEffect.SetActive(false);

        }
        
}
