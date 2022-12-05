using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    private Rigidbody PlayerRigid;

    // �÷��̾ ����ִ� ��ǰ
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
        // �÷��̾ ��ǰ ȹ��
        if (collision.gameObject.tag == "Item")
        {
            if (collision.gameObject.name == "Wheel_item")
            {
                collision.gameObject.SetActive(false);

                // �÷��̾ �ڵ� ����ִ� �κ��丮 â ��ȣ Ű ������ ��� -> ���߿� ����
                wheel_player.gameObject.SetActive(true);  // �÷��̾ �ڵ� ��� �ֱ�
            }
            if (collision.gameObject.name == "Propeller_item")
            {
                collision.gameObject.SetActive(false);

                // �÷��̾ �����緯 ����ִ� �κ��丮 â ��ȣ Ű ������ ��� -> ���߿� ����
                propeller_player.gameObject.SetActive(true);  // �÷��̾ �����緯 ��� �ֱ�
            }
        }
    }
}
