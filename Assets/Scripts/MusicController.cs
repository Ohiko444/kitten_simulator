using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;  // Присвойте ваш источник музыки в инспекторе
    public Button controlButton;     // Присвойте вашу кнопку в инспекторе
    private Image buttonImage;       // Компонент Image кнопки

    void Start()
    {
        buttonImage = controlButton.GetComponent<Image>();
        UpdateButtonColor();
    }

    // Метод для паузы/воспроизведения музыки
    public void ToggleMusic()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Pause();
        }
        else
        {
            musicSource.Play();
        }
        UpdateButtonColor();
    }

    // Метод для обновления цвета кнопки
    void UpdateButtonColor()
    {
        if (musicSource.isPlaying)
        {
            buttonImage.color = Color.black;  // Цвет кнопки, когда музыка играет
        }
        else
        {
            buttonImage.color = Color.red;    // Цвет кнопки, когда музыка на паузе
        }
    }
}
