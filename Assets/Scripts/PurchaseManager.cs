using UnityEngine;
using UnityEngine.UI;

public class PurchaseManager : MonoBehaviour
{
    public Text balanceText; // Текстовое поле для баланса
    public Text priceText; // Текстовое поле для цены
    public Image itemImage; // Изображение товара

    private int balance; // Текущий баланс игрока
    private int price; // Цена товара

    void Start()
    {
        UpdateValues(); // Обновляем значения при старте
        CheckBalance(); // Проверяем баланс при старте
    }

    void Update()
    {
        UpdateValues(); // Обновляем значения каждый кадр
        CheckBalance(); // Проверяем баланс каждый кадр
    }

    // Метод для обновления значений баланса и цены из текстовых полей
    private void UpdateValues()
    {
        int.TryParse(balanceText.text, out balance);
        int.TryParse(priceText.text, out price);
    }

    // Метод для проверки баланса
    private void CheckBalance()
    {
        if (balance >= price)
        {
            // Достаточно баланса для покупки
            itemImage.color = Color.green;
        }
        else
        {
            // Недостаточно баланса для покупки
            itemImage.color = Color.red;
        }
    }
}
