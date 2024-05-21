using UnityEngine;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Camera mainCamera;
    private Vector3 startPosition;
    private bool isReturning = false;

    public FoodBar foodBar; // Ссылка на скрипт полоски еды
    public GameObject cat; // Ссылка на объект cat
    public Image catFaceImage; // Ссылка на компонент Image с изображением лица кота

    private Sprite originalCatFaceSprite; // Исходный спрайт лица кота

    void Start()
    {
        mainCamera = Camera.main;
        startPosition = transform.position;

        // Сохраняем исходный спрайт лица кота
        originalCatFaceSprite = catFaceImage.sprite;
    }

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - GetMouseWorldPos();
        isReturning = false;
    }

    void OnMouseUp()
    {
        isDragging = false;
        if (!CheckCatCollision())
        {
            isReturning = true;
            ChangeCatFace(false); // Возвращаем обратно лицо кота
        }
    }

    void OnMouseEnter()
    {
        ChangeCatFace(true); // Меняем лицо кота
    }

    void OnMouseExit()
    {
        if (!isDragging) // Проверяем, не перетаскивается ли объект
        {
            ChangeCatFace(false); // Возвращаем обратно лицо кота
        }
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPos() + offset;
        }
        else if (isReturning)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, Time.deltaTime * 10);
            if (transform.position == startPosition)
            {
                isReturning = false;
            }
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mainCamera.WorldToScreenPoint(gameObject.transform.position).z;
        return mainCamera.ScreenToWorldPoint(mousePoint);
    }

    private bool CheckCatCollision()
    {
        Collider2D catCollider = cat.GetComponent<Collider2D>();
        if (catCollider != null && catCollider.bounds.Contains(transform.position))
        {
            foodBar.IncreaseFood(20);
            transform.position = startPosition;
            gameObject.SetActive(false);
            ChangeCatFace(false); // Восстанавливаем исходное лицо кота
            return true;
        }
        return false;
    }

    private void ChangeCatFace(bool isEnter)
    {
        if (isEnter)
        {
            // Меняем спрайт лица кота на новый спрайт
            catFaceImage.sprite = Resources.Load<Sprite>("Pet Your Cat (Demo)/Face_expressions/Fat Cats/4x/01_FatBrown_04");
        }
        else
        {
            // Восстанавливаем исходное лицо кота
            catFaceImage.sprite = originalCatFaceSprite;
        }
    }
}
