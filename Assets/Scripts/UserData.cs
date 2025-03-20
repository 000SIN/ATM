using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData //애를 컴포넌트로 사용하겠따 , mono를 상속받는 클래스 awake - TIL
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

    //은행에 입금하기
    //메서드
    public bool DepositBank(float money)
    {
        if (money <= 0)
        {
            return false;  // 입금액이 0 이하일 경우 실패
        }

        if(Cash <= money)
        {
            return false; // 현금이 money 금액보다 적을 경우 실패
        }

        Cash -= money;       // 현금에서 money 금액만큼 차감
        BankBalance += money; // 은행 잔액에 money 금액만큼 추가
        return true;
    }

    //은행에서 출금하기
    //메서드
    public bool WithdrawBank(float money)
    {
        if (money <= 0)
        {
            return false;  // 출금액이 0 이하일 경우 실패
        }

        Cash -= money;       // 현금에서 money 금액만큼 차감
        BankBalance += money; // 은행 잔액에 money 금액만큼 추가
        return true;
    }

}
