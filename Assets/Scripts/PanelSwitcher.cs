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
        // Убедимся, что панель еды видима при старте, а панель нужд скрыта
        SetCanvasGroupVisible(panelFood, true);
        SetCanvasGroupVisible(panelNeeds, false);

        // Добавляем слушатели для кнопок
        needsButton.onClick.AddListener(OnNeedsButtonClick);
        foodButton.onClick.AddListener(OnFoodButtonClick);
    }

    void OnNeedsButtonClick()
    {
        // Скрываем панель еды
        SetCanvasGroupVisible(panelFood, false);

        // Делаем видимой панель нужд
        SetCanvasGroupVisible(panelNeeds, true);
    }

    void OnFoodButtonClick()
    {
        // Скрываем панель нужд
        SetCanvasGroupVisible(panelNeeds, false);

        // Делаем видимой панель еды
        SetCanvasGroupVisible(panelFood, true);
    }

    void SetCanvasGroupVisible(CanvasGroup canvasGroup, bool visible)
    {
        canvasGroup.alpha = visible ? 1 : 0;
        canvasGroup.interactable = visible;
        canvasGroup.blocksRaycasts = visible;
    }
}
