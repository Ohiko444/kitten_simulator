using UnityEngine;
using UnityEngine.UI;

public class InactiveObjectsSum : MonoBehaviour
{
    public GameObject[] objectsToCheck; // Массив объектов для проверки
    public Text sumText; // Текстовое поле для отображения суммы

    private int lastInactiveCount = -1; // Последнее количество неактивных объектов

    void Start()
    {
        UpdateSumText(GetInactiveCount());
    }

    void Update()
    {
        // Проверяем состояние объектов каждый кадр
        int currentInactiveCount = GetInactiveCount();
        if (currentInactiveCount != lastInactiveCount)
        {
            lastInactiveCount = currentInactiveCount;
            UpdateSumText(currentInactiveCount);
        }
    }

    // Метод для подсчета неактивных объектов
    private int GetInactiveCount()
    {
        int inactiveCount = 0;

        // Проходимся по всем объектам и считаем неактивные
        foreach (GameObject obj in objectsToCheck)
        {
            if (!obj.activeSelf)
            {
                inactiveCount++;
            }
        }

        return inactiveCount;
    }

    // Метод для обновления суммы и текста
    private void UpdateSumText(int inactiveCount)
    {
        int sum = inactiveCount * 10;
        sumText.text = sum.ToString();
    }

    // Метод для переключения состояния объектов
    public void ToggleObjectState(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }
}
