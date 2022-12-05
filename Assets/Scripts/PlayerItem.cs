using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    private Rigidbody PlayerRigid;

    // 플레이어가 들고있는 부품
    public GameObject wheel_player;
    public GameObject propeller_player;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // 플레이어가 부품 획득
        if (collision.gameObject.tag == "Item")
        {
            if (collision.gameObject.name == "Wheel_item")
            {
                collision.gameObject.SetActive(false);

                // 플레이어가 핸들 들어있는 인벤토리 창 번호 키 눌렀을 경우 -> 나중에 구현
                wheel_player.gameObject.SetActive(true);  // 플레이어가 핸들 들고 있기
            }
            if (collision.gameObject.name == "Propeller_item")
            {
                collision.gameObject.SetActive(false);

                // 플레이어가 프로펠러 들어있는 인벤토리 창 번호 키 눌렀을 경우 -> 나중에 구현
                propeller_player.gameObject.SetActive(true);  // 플레이어가 프로펠러 들고 있기
            }
        }
    }
}
