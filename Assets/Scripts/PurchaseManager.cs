using UnityEngine;
using UnityEngine.UI;

public class PurchaseManager : MonoBehaviour
{
    public Text balanceText; // ��������� ���� ��� �������
    public Text priceText; // ��������� ���� ��� ����
    public Image itemImage; // ����������� ������

    private int balance; // ������� ������ ������
    private int price; // ���� ������

    void Start()
    {
        UpdateValues(); // ��������� �������� ��� ������
        CheckBalance(); // ��������� ������ ��� ������
    }

    void Update()
    {
        UpdateValues(); // ��������� �������� ������ ����
        CheckBalance(); // ��������� ������ ������ ����
    }

    // ����� ��� ���������� �������� ������� � ���� �� ��������� �����
    private void UpdateValues()
    {
        int.TryParse(balanceText.text, out balance);
        int.TryParse(priceText.text, out price);
    }

    // ����� ��� �������� �������
    private void CheckBalance()
    {
        if (balance >= price)
        {
            // ���������� ������� ��� �������
            itemImage.color = Color.green;
        }
        else
        {
            // ������������ ������� ��� �������
            itemImage.color = Color.red;
        }
    }
}
