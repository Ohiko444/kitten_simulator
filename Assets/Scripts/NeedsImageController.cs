using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NeedsImageController : MonoBehaviour
{
    public int restoreAmount; // ���������� ����������������� ������ ����
    public NeedsBar needsBar; // ������ �� ������ ���������� �������
    public Text timerText; // ������ �� ��������� ���� ��� ����������� �������

    private Image image; // ������ �� ��������� �����������
    private float respawnTime; // ����� �������������� � ��������
    private bool isRespawning = false;

    void Start()
    {
        image = GetComponent<Image>();
        if (restoreAmount == 15)
        {
            respawnTime = 15f;
        }
        else if (restoreAmount == 30)
        {
            respawnTime = 30f;
        }
        else if (restoreAmount == 50)
        {
            respawnTime = 50f;
        }
        else
        {
            respawnTime = 60f; // �������� �� ���������
        }
    }

    public void OnClick()
    {
        if (!isRespawning)
        {
            needsBar.IncreaseNeeds(restoreAmount);
            StartCoroutine(RespawnImage());
        }
    }

    IEnumerator RespawnImage()
    {
        image.enabled = false;
        isRespawning = true;

        float elapsedTime = 0f;

        while (elapsedTime < respawnTime)
        {
            elapsedTime += Time.deltaTime;
            float remainingTime = respawnTime - elapsedTime;
            timerText.text = $"{Mathf.CeilToInt(remainingTime)}s"; // ��������� ����� �������
            yield return null;
        }

        // ����� ���������� ������� ������� ����� "�����"
        timerText.text = "�����";
        image.enabled = true; // ��������������� �����������
        isRespawning = false;
    }
}
