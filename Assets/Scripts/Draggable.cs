using UnityEngine;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Camera mainCamera;
    private Vector3 startPosition;
    private bool isReturning = false;

    public FoodBar foodBar; // ������ �� ������ ������� ���
    public GameObject cat; // ������ �� ������ cat
    public Image catFaceImage; // ������ �� ��������� Image � ������������ ���� ����

    private Sprite originalCatFaceSprite; // �������� ������ ���� ����

    void Start()
    {
        mainCamera = Camera.main;
        startPosition = transform.position;

        // ��������� �������� ������ ���� ����
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
            ChangeCatFace(false); // ���������� ������� ���� ����
        }
    }

    void OnMouseEnter()
    {
        ChangeCatFace(true); // ������ ���� ����
    }

    void OnMouseExit()
    {
        if (!isDragging) // ���������, �� ��������������� �� ������
        {
            ChangeCatFace(false); // ���������� ������� ���� ����
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
            ChangeCatFace(false); // ��������������� �������� ���� ����
            return true;
        }
        return false;
    }

    private void ChangeCatFace(bool isEnter)
    {
        if (isEnter)
        {
            // ������ ������ ���� ���� �� ����� ������
            catFaceImage.sprite = Resources.Load<Sprite>("Pet Your Cat (Demo)/Face_expressions/Fat Cats/4x/01_FatBrown_04");
        }
        else
        {
            // ��������������� �������� ���� ����
            catFaceImage.sprite = originalCatFaceSprite;
        }
    }
}
