using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public int clickCount = 0; // ���������� ��� �������� ���������� ������
    public Text clickCountText; // ������ �� ��������� ����, ��� ����� ������������ ���������� ������
    public Text clickCountTextEnd; // ������ �� ��������� ����, ��� ����� ������������ ���������� ������

    // �����, ���������� ��� ������� �� ������
    public void OnButtonClick()
    {
        // �������� ������� �������� �� ���������� ����
        int currentCount = int.Parse(clickCountTextEnd.text);

        // ����������� �������� �� 1
        currentCount++;

        // ���������� ����� �������� ������� � ��������� ����
        clickCountTextEnd.text = currentCount.ToString();

        // ��������� ����������� ���������� ������ � ��������� ����
        clickCountText.text = currentCount.ToString();

        // ����������� ���������� ������ �� 1
        clickCount++;
    }
}
