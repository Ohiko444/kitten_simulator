using UnityEngine;
using UnityEngine.UI;

public class InactiveObjectsSum : MonoBehaviour
{
    public GameObject[] objectsToCheck; // ������ �������� ��� ��������
    public Text sumText; // ��������� ���� ��� ����������� �����

    private int lastInactiveCount = -1; // ��������� ���������� ���������� ��������

    void Start()
    {
        UpdateSumText(GetInactiveCount());
    }

    void Update()
    {
        // ��������� ��������� �������� ������ ����
        int currentInactiveCount = GetInactiveCount();
        if (currentInactiveCount != lastInactiveCount)
        {
            lastInactiveCount = currentInactiveCount;
            UpdateSumText(currentInactiveCount);
        }
    }

    // ����� ��� �������� ���������� ��������
    private int GetInactiveCount()
    {
        int inactiveCount = 0;

        // ���������� �� ���� �������� � ������� ����������
        foreach (GameObject obj in objectsToCheck)
        {
            if (!obj.activeSelf)
            {
                inactiveCount++;
            }
        }

        return inactiveCount;
    }

    // ����� ��� ���������� ����� � ������
    private void UpdateSumText(int inactiveCount)
    {
        int sum = inactiveCount * 10;
        sumText.text = sum.ToString();
    }

    // ����� ��� ������������ ��������� ��������
    public void ToggleObjectState(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }
}
