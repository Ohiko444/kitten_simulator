using UnityEngine;
using UnityEngine.UI;

public class CatNeedsDecay : MonoBehaviour
{
    public Slider foodSlider; // Ссылка на слайдер еды
    public Slider needsSlider; // Ссылка на слайдер нужд

    private float decayRate = 1f; // Скорость уменьшения показателей (единиц в минуту)

    void Start()
    {
        // Запускаем уменьшение показателей каждую минуту
        InvokeRepeating("DecayNeeds", 10f, 10f);
    }

    void DecayNeeds()
    {
        // Уменьшаем показатели еды и нужд на единицу
        foodSlider.value -= decayRate;
        needsSlider.value -= decayRate;
    }
}
