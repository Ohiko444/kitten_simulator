using UnityEngine;
using UnityEngine.UI;

public class FoodOpen: MonoBehaviour
{
    public CanvasGroup panelFood; // ���������� ���� Panel_Food � ����������
    public CanvasGroup panelNeeds; // ���������� ���� Panel_Needs � ����������
    public Button foodButton; // ���������� ���� Needs_Button � ����������

    void Start()
    {
        // ��������, ��� ������ ���� ������ ��� ������ � ������ ��� ������
        SetCanvasGroupVisible(panelFood, false);
        SetCanvasGroupVisible(panelNeeds, true);

        // ��������� ��������� ��� ������
        foodButton.onClick.AddListener(OnFoodButtonClick);
        Debug.Log("Button listener added");
    }

    void OnFoodButtonClick()
    {
        Debug.Log("Button clicked");

        // �������� ������ ���
        SetCanvasGroupVisible(panelFood, true);
        Debug.Log("Panel_Food hidden");

        // ������ ������� ������ ����
        SetCanvasGroupVisible(panelNeeds, false);
        Debug.Log("Panel_Needs shown");
    }

    void SetCanvasGroupVisible(CanvasGroup canvasGroup, bool visible)
    {
        canvasGroup.alpha = visible ? 0 : 1;
        canvasGroup.interactable = visible;
        canvasGroup.blocksRaycasts = visible;
    }
}
