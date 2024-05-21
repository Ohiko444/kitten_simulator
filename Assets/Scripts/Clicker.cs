using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public int clickCount = 0; // ѕеременна€ дл€ хранени€ количества кликов
    public Text clickCountText; // —сылка на текстовое поле, где будет отображатьс€ количество кликов
    public Text clickCountTextEnd; // —сылка на текстовое поле, где будет отображатьс€ количество кликов

    // ћетод, вызываемый при нажатии на кнопку
    public void OnButtonClick()
    {
        // ѕолучаем текущее значение из текстового пол€
        int currentCount = int.Parse(clickCountTextEnd.text);

        // ”величиваем значение на 1
        currentCount++;

        // «аписываем новое значение обратно в текстовое поле
        clickCountTextEnd.text = currentCount.ToString();

        // ќбновл€ем отображение количества кликов в текстовом поле
        clickCountText.text = currentCount.ToString();

        // ”величиваем количество кликов на 1
        clickCount++;
    }
}
