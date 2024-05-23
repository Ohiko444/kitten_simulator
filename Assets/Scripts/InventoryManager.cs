using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Text balanceText; // ��������� ���� ��� �������
    public Text priceText; // ��������� ���� ��� ����
    public Button purchaseButton; // ������ �������
    public GameObject[] inventoryItems; // ������ �������� ���������

    private int balance; // ������� ������ ������
    private int price; // ���� ������

    void Start()
    {
        // ����������� ����� OnPurchaseButtonClick ������
        purchaseButton.onClick.AddListener(OnPurchaseButtonClick);
    }

    void Update()
    {
        // ��������� �������� ������� � ���� �� ��������� ����� ������ ����
        int.TryParse(balanceText.text, out balance);
        int.TryParse(priceText.text, out price);
    }

    // �����, ���������� ��� ������� �� ������
    private void OnPurchaseButtonClick()
    {
        if (balance >= price)
        {
            // �������� ���� �� �������
            balance -= price;
            // ��������� ����� �������
            balanceText.text = balance.ToString();

            // ��������� 12 ��������� ��������� � ���������� ����������
            foreach (GameObject item in inventoryItems)
            {
                if (!item.activeSelf)
                {
                    item.SetActive(true);
                }
            }
        }
        else
        {
            Debug.Log("������������ ������� ��� �������.");
        }
    }
}
