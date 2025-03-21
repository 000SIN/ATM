using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // 싱글톤 패턴 - GameManager 인스턴스화
    public static GameManager Instance;


    // UserData 참조 변수
    public static UserData userData;

    public TextMeshProUGUI userNameText;
    public TextMeshProUGUI bankBalanceText;
    public TextMeshProUGUI cashText;

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

    void Start()
    {
        Refresh();
    }

         public void Refresh()
    {
        // UI에 이름, 현금, 잔액을 업데이트
        userNameText.text = userData.Username;
        cashText.text = string.Format("{0:N0}", userData.Cash);
        bankBalanceText.text = string.Format("{0:N0}", userData.BankBalance);
        //string.Format을 사용하면, 텍스트를 동적으로 생성할 때 변수의 값을 다양한 형식으로 변환할 수 있음
        //{0:N0} = 앞에 0은 첫번째 인수를 참조한다는 뜻 / N은 천단위 소수점, 0은 소수점 위에 허용가능한 숫자가 0개라는 거
    }
}


  
