using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
    public Slider foodSlider; // ������ �� UI Slider
    public Text foodText; // ������ �� UI Text

    void Start()
    {
        UpdateFoodText();
        foodSlider.onValueChanged.AddListener(delegate { UpdateFoodText(); });
    }

    public void IncreaseFood(int amount)
    {
        foodSlider.value += amount;
        UpdateFoodText();
    }

    private void UpdateFoodText()
    {
        foodText.text = $"{foodSlider.value}/{foodSlider.maxValue}";
    }
}
