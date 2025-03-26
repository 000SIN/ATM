using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 싱글톤 패턴 - GameManager 인스턴스화
    public static GameManager Instance;

    // UserData 참조 변수
    public UserData userData;

    public TextMeshProUGUI userNameText;
    public TextMeshProUGUI bankBalanceText;
    public TextMeshProUGUI cashText;


    public GameObject errorPopup;  // 잔액 부족 시 표시할 팝업

    //생성자를 통해 이름과 현금, 통장 잔액 데이터 넣기

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // 저장된 데이터가 있을 경우에만 로드
        if (PlayerPrefs.HasKey("BankBalance") && PlayerPrefs.HasKey("Cash"))
        {
            userData.LoadUserData();
        }
        else
        {
            // 저장된 데이터가 없으면 기본 값 설정
            userData = new UserData("sung", 50000, 30000);
        }
    }


    public void Start()
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

    private void OnApplicationQuit()
    {
        userData.SaveUserData();
    }


}



