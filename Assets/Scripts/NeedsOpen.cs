using UnityEngine;
using UnityEngine.UI;

public class NeedsOpen: MonoBehaviour
{
    public CanvasGroup panelFood; // ���������� ���� Panel_Food � ����������
    public CanvasGroup panelNeeds; // ���������� ���� Panel_Needs � ����������
    public Button needsButton; // ���������� ���� Needs_Button � ����������

    void Start()
    {
        // ��������, ��� ������ ���� ������ ��� ������ � ������ ��� ������
        SetCanvasGroupVisible(panelFood, true);
        SetCanvasGroupVisible(panelNeeds, false);

        // ��������� ��������� ��� ������
        needsButton.onClick.AddListener(OnNeedsButtonClick);
        Debug.Log("Button listener added");
    }

    void OnNeedsButtonClick()
    {
        Debug.Log("Button clicked");

        // �������� ������ ���
        SetCanvasGroupVisible(panelFood, false);
        Debug.Log("Panel_Food hidden");

        // ������ ������� ������ ����
        SetCanvasGroupVisible(panelNeeds, true);
        Debug.Log("Panel_Needs shown");
    }

    void SetCanvasGroupVisible(CanvasGroup canvasGroup, bool visible)
    {
        canvasGroup.alpha = visible ? 1 : 0;
        canvasGroup.interactable = visible;
        canvasGroup.blocksRaycasts = visible;
    }
}
