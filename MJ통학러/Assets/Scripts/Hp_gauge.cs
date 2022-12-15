using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp_gauge : MonoBehaviour
{
    public GameObject player;
    public Slider hpBar;
    public static float currentHp;
    public float maxHp = 1.0f;

    void Start()
    {
        currentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.value= currentHp / maxHp;
        if(currentHp <= 0.0f){
            Destroy(gameObject);
            Destroy(player);
        }
    }

    //hpgauge가 player를 따라가는 속도를 못맞춤 - 속도 조정 필요
    //hpgauge asset을 하나 설정해야 할 듯 - 지금은 원형

    /*float fHorizontal = Input.GetAxis("Horizontal");
        float fVertical = Input.GetAxis("Vertical");
 
        transform.Translate(Vector3.right * Time.deltaTime * m_fSpeed * fHorizontal, Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * m_fSpeed * fVertical, Space.World);
        // 테스트를 위한 키보드 이동 끝
 
 
        // 오브젝트에 따른 HP Bar 위치 이동
        m_goHpBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));*/
}