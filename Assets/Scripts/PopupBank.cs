using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupBank : MonoBehaviour
{

    public GameObject Deposit;
    public GameObject Withdraw;
    public GameObject ATM; // ATM 패널 (Inspector에서 할당)

    public TMP_InputField DepoistField; // 입금
    public TMP_InputField WithdrawField;// 출금

    public GameObject ErrorPopup; // ErrorPopup 오브젝트


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

    public void DepoistBtn(float getMoney)
    {
        if (GameManager.Instance.userData.Cash < getMoney)
        {
            OpenErrorPopup();
            return;
        }
        GameManager.Instance.userData.BankBalance += getMoney;
        GameManager.Instance.userData.Cash -= getMoney;
        GameManager.Instance.Refresh();
    }

    public void Depoist_Btn()
    {
        float getInputMoney = float.Parse(DepoistField.text); //형변환(변수)
        DepoistBtn(getInputMoney);
    }

    public void WithdrawBtn(float getMoney)
    {
        // 통장 잔고가 부족하면 팝업을 띄움
        if (GameManager.Instance.userData.BankBalance < getMoney)
        {
            OpenErrorPopup();
            return;
        }
        GameManager.Instance.userData.BankBalance -= getMoney;
        GameManager.Instance.userData.Cash += getMoney;
        GameManager.Instance.Refresh();
    }

    public void Withdraw_Btn()
    {
        float getOutputMoney = float.Parse(WithdrawField.text); //형변환(변수)
        WithdrawBtn(getOutputMoney);
    }


    public void OpenErrorPopup()
    {
        ErrorPopup.SetActive(true);
    }

    // OK 버튼을 누르면 팝업을 닫는 함수
    public void CloseErrorPopup()
    {
        ErrorPopup.SetActive(false); // 팝업 비활성화
    }

}
