using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupBank : MonoBehaviour
{

    public GameObject Deposit;
    public GameObject Withdraw;
    public GameObject ATM; // ATM 패널 (Inspector에서 할당)

    void Awake()
    {
        ATM.SetActive(true); // 게임 시작 시 ATM 패널 활성화

    }
    public void OpenDeposit()
    {
        Deposit.SetActive(true);
        Withdraw.SetActive(false);
        ATM.SetActive(false);
    }

    public void OpenWithdraw()
    { 
        Deposit.SetActive(false);
        Withdraw.SetActive(true);
        ATM.SetActive(false);
    }

    public void OpenATM()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        ATM.SetActive(true);
    }

}
