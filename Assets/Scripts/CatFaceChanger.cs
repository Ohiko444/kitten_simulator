using UnityEngine;
using UnityEngine.UI;

public class CatFaceChanger : MonoBehaviour
{
    public Slider foodSlider; // Ссылка на слайдер еды
    public Slider needsSlider; // Ссылка на слайдер нужд
    public Image catFaceImage; // Ссылка на компонент Image с изображением лица кота

    public Sprite happyFaceSprite; // Спрайт для счастливого лица кота
    public Sprite neutralFaceSprite; // Спрайт для среднего лица кота
    public Sprite sadFaceSprite; // Спрайт для грустного лица кота

    void Update()
    {
        // Проверяем текущие значения слайдеров еды и нужд
        float foodValue = foodSlider.value;
        float needsValue = needsSlider.value;

        // Исходное лицо кота - среднее
        Sprite currentFaceSprite = neutralFaceSprite;

        // Если показатели падают ниже определенного уровня, меняем лицо кота на грустное
        if (foodValue < 30 || needsValue < 30)
        {
            currentFaceSprite = sadFaceSprite;
        }
        // Если показатели выше определенного уровня, меняем лицо кота на счастливое
        else if (foodValue > 70 && needsValue > 70)
        {
            currentFaceSprite = happyFaceSprite;
        }

        // Устанавливаем спрайт лица кота
        catFaceImage.sprite = currentFaceSprite;
    }
}
