using UnityEngine;
using UnityEngine.UI;

public class CreditsMenuView : View
{
    [SerializeField] private Button _backButton;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _buttonClickSFX;

    public override void Initialize()
    {
        _backButton.onClick.AddListener(() => OnBackButtonClick());
    }

    private void OnBackButtonClick()
    {
        if (_audioSource && _buttonClickSFX)
        {
            _audioSource.PlayOneShot(_buttonClickSFX);
        }
        ViewManager.ShowLast();
    }
}
