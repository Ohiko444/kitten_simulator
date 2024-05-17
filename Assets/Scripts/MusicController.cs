using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;  // ��������� ��� �������� ������ � ����������
    public Button controlButton;     // ��������� ���� ������ � ����������
    private Image buttonImage;       // ��������� Image ������

    void Start()
    {
        buttonImage = controlButton.GetComponent<Image>();
        UpdateButtonColor();
    }

    // ����� ��� �����/��������������� ������
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

    // ����� ��� ���������� ����� ������
    void UpdateButtonColor()
    {
        if (musicSource.isPlaying)
        {
            buttonImage.color = Color.black;  // ���� ������, ����� ������ ������
        }
        else
        {
            buttonImage.color = Color.red;    // ���� ������, ����� ������ �� �����
        }
    }
}
