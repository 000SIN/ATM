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



}
