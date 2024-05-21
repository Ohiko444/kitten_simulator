using UnityEngine;
using UnityEngine.UI;

public class CatFaceChanger : MonoBehaviour
{
    public Slider foodSlider; // ������ �� ������� ���
    public Slider needsSlider; // ������ �� ������� ����
    public Image catFaceImage; // ������ �� ��������� Image � ������������ ���� ����

    public Sprite happyFaceSprite; // ������ ��� ����������� ���� ����
    public Sprite neutralFaceSprite; // ������ ��� �������� ���� ����
    public Sprite sadFaceSprite; // ������ ��� ��������� ���� ����

    void Update()
    {
        // ��������� ������� �������� ��������� ��� � ����
        float foodValue = foodSlider.value;
        float needsValue = needsSlider.value;

        // �������� ���� ���� - �������
        Sprite currentFaceSprite = neutralFaceSprite;

        // ���� ���������� ������ ���� ������������� ������, ������ ���� ���� �� ��������
        if (foodValue < 30 || needsValue < 30)
        {
            currentFaceSprite = sadFaceSprite;
        }
        // ���� ���������� ���� ������������� ������, ������ ���� ���� �� ����������
        else if (foodValue > 70 && needsValue > 70)
        {
            currentFaceSprite = happyFaceSprite;
        }

        // ������������� ������ ���� ����
        catFaceImage.sprite = currentFaceSprite;
    }
}
