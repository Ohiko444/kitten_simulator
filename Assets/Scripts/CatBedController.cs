using UnityEngine;
using UnityEngine.UI;

public class CatBedController : MonoBehaviour
{
    public Image bedImage; // ��������� Image ��������� ��� ������� � ����������
    public Button girlButton; // ������ ������ ���� girl
    public Button manButton; // ������ ������ ���� man
    public Button okButton; // ������ OK

    private string selectedGender; // ������ ��������� ���
    private Color normalColor = new Color(1, 1, 1, 1); // ������� ���� ������ (������������)
    private Color fadedColor = new Color(1, 1, 1, 0.5f); // �������������� ���� ������

    void Start()
    {
        // ����������� ����������� ������� ��� ������
        girlButton.onClick.AddListener(() => SelectGender("girl"));
        manButton.onClick.AddListener(() => SelectGender("man"));
        okButton.onClick.AddListener(UpdateBedImage);

        // ������������� ��������� ����� ������
        girlButton.GetComponent<Image>().color = fadedColor;
        manButton.GetComponent<Image>().color = fadedColor;
    }

    // ����� ��� ������ ����
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

    // ����� ��� ���������� ����������� �������
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
