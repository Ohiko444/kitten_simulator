using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseSetting : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public Button CloseRate;

    private void Start()
    {
        CloseRate.onClick.AddListener(Close);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
