using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NeedsBar : MonoBehaviour
{
    public Slider needsSlider; // —сылка на UI Slider
    public Text needsText; // —сылка на Text

    void Start()
    {
        UpdateNeedsText();
        needsSlider.onValueChanged.AddListener(delegate { UpdateNeedsText(); });
    }

    public void IncreaseNeeds(int amount)
    {
        needsSlider.value += amount;
        UpdateNeedsText();
    }

    private void UpdateNeedsText()
    {
        needsText.text = $"{needsSlider.value}/{needsSlider.maxValue}";
    }
}
