using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �̱��� ���� - GameManager �ν��Ͻ�ȭ
    public static GameManager Instance;


    // UserData ���� ����
    public UserData userData;

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

}

