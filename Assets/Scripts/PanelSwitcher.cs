using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public CanvasGroup panelFood;
    public CanvasGroup panelNeeds; 
    public Button needsButton; 
    public Button foodButton; 

    void Start()
    {
        // ��������, ��� ������ ��� ������ ��� ������, � ������ ���� ������
        SetCanvasGroupVisible(panelFood, true);
        SetCanvasGroupVisible(panelNeeds, false);

        // ��������� ��������� ��� ������
        needsButton.onClick.AddListener(OnNeedsButtonClick);
        foodButton.onClick.AddListener(OnFoodButtonClick);
    }

    void OnNeedsButtonClick()
    {
        // �������� ������ ���
        SetCanvasGroupVisible(panelFood, false);

        // ������ ������� ������ ����
        SetCanvasGroupVisible(panelNeeds, true);
    }

    void OnFoodButtonClick()
    {
        // �������� ������ ����
        SetCanvasGroupVisible(panelNeeds, false);

        // ������ ������� ������ ���
        SetCanvasGroupVisible(panelFood, true);
    }

    void SetCanvasGroupVisible(CanvasGroup canvasGroup, bool visible)
    {
        canvasGroup.alpha = visible ? 1 : 0;
        canvasGroup.interactable = visible;
        canvasGroup.blocksRaycasts = visible;
    }
}
