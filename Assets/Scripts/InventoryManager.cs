using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Text balanceText; // Текстовое поле для баланса
    public Text priceText; // Текстовое поле для цены
    public Button purchaseButton; // Кнопка покупки
    public GameObject[] inventoryItems; // Массив объектов инвентаря

    private int balance; // Текущий баланс игрока
    private int price; // Цена товара

    void Start()
    {
        // Присваиваем метод OnPurchaseButtonClick кнопке
        purchaseButton.onClick.AddListener(OnPurchaseButtonClick);
    }

    void Update()
    {
        // Обновляем значения баланса и цены из текстовых полей каждый кадр
        int.TryParse(balanceText.text, out balance);
        int.TryParse(priceText.text, out price);
    }

    // Метод, вызываемый при нажатии на кнопку
    private void OnPurchaseButtonClick()
    {
        if (balance >= price)
        {
            // Вычитаем цену из баланса
            balance -= price;
            // Обновляем текст баланса
            balanceText.text = balance.ToString();

            // Проверяем 12 элементов инвентаря и активируем неактивные
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
            Debug.Log("Недостаточно средств для покупки.");
        }
    }
}
