using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NeedsImageController : MonoBehaviour
{
    public int restoreAmount; // Количество восстанавливаемых единиц нужд
    public NeedsBar needsBar; // Ссылка на скрипт управления нуждами
    public Text timerText; // Ссылка на текстовое поле для отображения таймера

    private Image image; // Ссылка на компонент изображения
    private float respawnTime; // Время восстановления в секундах
    private bool isRespawning = false;

    void Start()
    {
        image = GetComponent<Image>();
        if (restoreAmount == 15)
        {
            respawnTime = 15f;
        }
        else if (restoreAmount == 30)
        {
            respawnTime = 30f;
        }
        else if (restoreAmount == 50)
        {
            respawnTime = 50f;
        }
        else
        {
            respawnTime = 60f; // Значение по умолчанию
        }
    }

    public void OnClick()
    {
        if (!isRespawning)
        {
            needsBar.IncreaseNeeds(restoreAmount);
            StartCoroutine(RespawnImage());
        }
    }

    IEnumerator RespawnImage()
    {
        image.enabled = false;
        isRespawning = true;

        float elapsedTime = 0f;

        while (elapsedTime < respawnTime)
        {
            elapsedTime += Time.deltaTime;
            float remainingTime = respawnTime - elapsedTime;
            timerText.text = $"{Mathf.CeilToInt(remainingTime)}s"; // Обновляем текст таймера
            yield return null;
        }

        // После завершения таймера выводим текст "ГОТОВ"
        timerText.text = "готов";
        image.enabled = true; // Восстанавливаем изображение
        isRespawning = false;
    }
}
