using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // �̱��� ���� - GameManager �ν��Ͻ�ȭ
    public static GameManager Instance;


    // UserData ���� ����
    public static UserData userData;

    public TextMeshProUGUI userNameText;
    public TextMeshProUGUI bankBalanceText;
    public TextMeshProUGUI cashText;

    //�����ڸ� ���� �̸��� ����, ���� �ܾ� ������ �ֱ�
    public void Awake()
    {
        if (Instance == null) //���� ��ü�� null�̶��
        {
            Instance = this; //��ü�� �̰��� ����� ��
        }
        
        else
            Destroy(gameObject); //�̹� Instance�� �����ϸ� ���ο�� ����

        //userData = new UserData(name, cash, BankBalance); �����ΰ�
        userData = new UserData("sung", 50000, 10000);
    }

    void Start()
    {
        Refresh();
    }

         public void Refresh()
    {
        // UI�� �̸�, ����, �ܾ��� ������Ʈ
        userNameText.text = userData.Username;
        cashText.text = string.Format("{0:N0}", userData.Cash);
        bankBalanceText.text = string.Format("{0:N0}", userData.BankBalance);
        //string.Format�� ����ϸ�, �ؽ�Ʈ�� �������� ������ �� ������ ���� �پ��� �������� ��ȯ�� �� ����
        //{0:N0} = �տ� 0�� ù��° �μ��� �����Ѵٴ� �� / N�� õ���� �Ҽ���, 0�� �Ҽ��� ���� ��밡���� ���ڰ� 0����� ��
    }
}


  
