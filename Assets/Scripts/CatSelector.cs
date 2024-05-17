using UnityEngine;
using UnityEngine.UI;

public class CatSelector : MonoBehaviour
{
    public Image catImage; // Присвойте Image компонент для кота в инспекторе
    public Button cat1Button;
    public Button cat2Button;
    public Button cat3Button;
    public Button cat4Button;
    public Button cat5Button;
    public Button cat6Button;

    private string[] catImagePaths = {
        "Pet Your Cat (Demo)/Cats_Whole/4x/cat_01",
        "Pet Your Cat (Demo)/Cats_Whole/4x/cat_02",
        "Pet Your Cat (Demo)/Cats_Whole/4x/cat_28",
        "Pet Your Cat (Demo)/Cats_Whole/4x/cat_35",
        "Pet Your Cat (Demo)/Cats_Whole/4x/cat_36",
        "Pet Your Cat (Demo)/Cats_Whole/4x/cat_53"
    };

    void Start()
    {
        cat1Button.onClick.AddListener(() => SelectCat(0));
        cat2Button.onClick.AddListener(() => SelectCat(1));
        cat3Button.onClick.AddListener(() => SelectCat(2));
        cat4Button.onClick.AddListener(() => SelectCat(3));
        cat5Button.onClick.AddListener(() => SelectCat(4));
        cat6Button.onClick.AddListener(() => SelectCat(5));
    }

    // Метод для выбора кота
    void SelectCat(int index)
    {
        if (index >= 0 && index < catImagePaths.Length)
        {
            catImage.sprite = Resources.Load<Sprite>(catImagePaths[index]);
        }
        else
        {
            Debug.LogWarning("Invalid cat index selected!");
        }
    }
}
