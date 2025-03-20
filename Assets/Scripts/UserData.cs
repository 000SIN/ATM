using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData //�ָ� ������Ʈ�� ����ϰڵ� , mono�� ��ӹ޴� Ŭ���� awake - TIL
{
    //���� ����
    public string Username; //�̸�
    public float BankBalance; //���� �ܾ�
    public float Cash; //����(money�� �����â�� �ִ� ��)

    //������ : �⺻����
    public UserData()
    {
        Username = "Unknown";
        Cash = 0f;
        BankBalance = 0f;
    }

    //�Ű����� ������ : �ʱ�ȭ, Ŭ���� ���� = �Ű�����
    public UserData(string username, float cash, float bankBalance)
    {
        Username = username;
        Cash = cash;
        BankBalance = bankBalance;
    }

    //���࿡ �Ա��ϱ�
    //�޼���
    public bool DepositBank(float money)
    {
        if (money <= 0)
        {
            return false;  // �Աݾ��� 0 ������ ��� ����
        }

        if(Cash <= money)
        {
            return false; // ������ money �ݾ׺��� ���� ��� ����
        }

        Cash -= money;       // ���ݿ��� money �ݾ׸�ŭ ����
        BankBalance += money; // ���� �ܾ׿� money �ݾ׸�ŭ �߰�
        return true;
    }

    //���࿡�� ����ϱ�
    //�޼���
    public bool WithdrawBank(float money)
    {
        if (money <= 0)
        {
            return false;  // ��ݾ��� 0 ������ ��� ����
        }

        Cash -= money;       // ���ݿ��� money �ݾ׸�ŭ ����
        BankBalance += money; // ���� �ܾ׿� money �ݾ׸�ŭ �߰�
        return true;
    }

}
