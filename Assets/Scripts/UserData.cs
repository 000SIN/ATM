using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData 
{
    //변수 선언
    public string Username; //이름
    public float BankBalance; //통장 잔액
    public float Cash; //현금(money는 입출금창에 있는 돈)

    //생성자 : 기본상태
    public UserData()
    {
        Username = "Unknown";
        Cash = 0f;
        BankBalance = 0f;
    }

    //매개변수 생성자 : 초기화, 클래스 변수 = 매개변수
    public UserData(string username, float cash, float bankBalance)
    {
        Username = username;
        Cash = cash;
        BankBalance = bankBalance;
    }

    // UserData 클래스에 저장 및 로드 기능 추가
    public void LoadUserData()
    {
        Username = PlayerPrefs.GetString("Username", "Unknown");
        Cash = PlayerPrefs.GetFloat("Cash", 0f);// Cash에저장된 값이 없으면, cash는 0f로 설정됨
        BankBalance = PlayerPrefs.GetFloat("BankBalance", 0f); //BankBalance도 이하동문
    }

    public void SaveUserData()
    {
        PlayerPrefs.SetString("Username", Username);
        PlayerPrefs.SetFloat("Cash", Cash);
        PlayerPrefs.SetFloat("BankBalance", BankBalance);
        PlayerPrefs.Save(); // 변경사항을 저장
    }


}
