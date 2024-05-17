using UnityEngine;
using UnityEngine.UI;

public class CatBedController : MonoBehaviour
{
    public Image bedImage; // Присвойте Image компонент для лежанки в инспекторе
    public Button girlButton; // Кнопка выбора пола girl
    public Button manButton; // Кнопка выбора пола man
    public Button okButton; // Кнопка OK

    private string selectedGender; // Хранит выбранный пол
    private Color normalColor = new Color(1, 1, 1, 1); // Обычный цвет кнопки (непрозрачный)
    private Color fadedColor = new Color(1, 1, 1, 0.5f); // Полупрозрачный цвет кнопки

    void Start()
    {
        // Присваиваем обработчики событий для кнопок
        girlButton.onClick.AddListener(() => SelectGender("girl"));
        manButton.onClick.AddListener(() => SelectGender("man"));
        okButton.onClick.AddListener(UpdateBedImage);

        // Устанавливаем начальные цвета кнопок
        girlButton.GetComponent<Image>().color = fadedColor;
        manButton.GetComponent<Image>().color = fadedColor;
    }

    // Метод для выбора пола
    void SelectGender(string gender)
    {
        selectedGender = gender;

        if (selectedGender == "girl")
        {
            girlButton.GetComponent<Image>().color = normalColor;
            manButton.GetComponent<Image>().color = fadedColor;
        }
        else if (selectedGender == "man")
        {
            girlButton.GetComponent<Image>().color = fadedColor;
            manButton.GetComponent<Image>().color = normalColor;
        }
    }

    // Метод для обновления изображения лежанки
    void UpdateBedImage()
    {
        if (selectedGender == "girl")
        {
            bedImage.sprite = Resources.Load<Sprite>("Pet Your Cat (Demo)/Bed/4x/04_Bed");
        }
        else if (selectedGender == "man")
        {
            bedImage.sprite = Resources.Load<Sprite>("Pet Your Cat (Demo)/Bed/4x/01_Bed");
        }
        else
        {
            Debug.LogWarning("Gender not selected!");
        }
    }
}
