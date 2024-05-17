using UnityEngine;
using UnityEngine.UI;

public class NeedsOpen: MonoBehaviour
{
    public CanvasGroup panelFood; // Перетащите сюда Panel_Food в инспекторе
    public CanvasGroup panelNeeds; // Перетащите сюда Panel_Needs в инспекторе
    public Button needsButton; // Перетащите сюда Needs_Button в инспекторе

    void Start()
    {
        // Убедимся, что панель нужд скрыта при старте и панель еды видима
        SetCanvasGroupVisible(panelFood, true);
        SetCanvasGroupVisible(panelNeeds, false);

        // Добавляем слушатель для кнопки
        needsButton.onClick.AddListener(OnNeedsButtonClick);
        Debug.Log("Button listener added");
    }

    void OnNeedsButtonClick()
    {
        Debug.Log("Button clicked");

        // Скрываем панель еды
        SetCanvasGroupVisible(panelFood, false);
        Debug.Log("Panel_Food hidden");

        // Делаем видимой панель нужд
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
