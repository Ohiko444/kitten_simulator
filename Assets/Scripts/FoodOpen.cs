using UnityEngine;
using UnityEngine.UI;

public class FoodOpen: MonoBehaviour
{
    public CanvasGroup panelFood; // Перетащите сюда Panel_Food в инспекторе
    public CanvasGroup panelNeeds; // Перетащите сюда Panel_Needs в инспекторе
    public Button foodButton; // Перетащите сюда Needs_Button в инспекторе

    void Start()
    {
        // Убедимся, что панель нужд скрыта при старте и панель еды видима
        SetCanvasGroupVisible(panelFood, false);
        SetCanvasGroupVisible(panelNeeds, true);

        // Добавляем слушатель для кнопки
        foodButton.onClick.AddListener(OnFoodButtonClick);
        Debug.Log("Button listener added");
    }

    void OnFoodButtonClick()
    {
        Debug.Log("Button clicked");

        // Скрываем панель еды
        SetCanvasGroupVisible(panelFood, true);
        Debug.Log("Panel_Food hidden");

        // Делаем видимой панель нужд
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
