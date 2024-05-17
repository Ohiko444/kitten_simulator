using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSetting : MonoBehaviour
{
    public Button Rate_Button;

    public CloseSetting rateDialog;

    void Start()
    {
        Rate_Button.onClick.AddListener(OnRate);
    }

    void OnRate()
    {
        rateDialog.Open();
    }

    void Update()
    {

    }
}
