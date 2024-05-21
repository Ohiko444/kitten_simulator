using UnityEngine;
using UnityEngine.UI;

public class CatNeedsDecay : MonoBehaviour
{
    public Slider foodSlider; // ������ �� ������� ���
    public Slider needsSlider; // ������ �� ������� ����

    private float decayRate = 1f; // �������� ���������� ����������� (������ � ������)

    void Start()
    {
        // ��������� ���������� ����������� ������ ������
        InvokeRepeating("DecayNeeds", 10f, 10f);
    }

    void DecayNeeds()
    {
        // ��������� ���������� ��� � ���� �� �������
        foodSlider.value -= decayRate;
        needsSlider.value -= decayRate;
    }
}
