using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 싱글톤 패턴 - GameManager 인스턴스화
    public static GameManager Instance;


    // UserData 참조 변수
    public UserData userData;

    //생성자를 통해 이름과 현금, 통장 잔액 데이터 넣기
    public void Awake()
    {
        if (Instance == null) //만약 객체가 null이라면
        {
            Instance = this; //객체는 이것을 사용할 것
        }
        
        else
            Destroy(gameObject); //이미 Instance가 존재하면 새로운건 삭제

        //userData = new UserData(name, cash, BankBalance); 형태인것
        userData = new UserData("sung", 50000, 10000);
    }

}

