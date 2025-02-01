using UnityEngine;
using UnityEngine.UI;

public class QuitConfirmationView : View
{
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _backSFX;
    [SerializeField] private AudioClip _quitSFX;

    public override void Initialize()
    {
        _backButton.onClick.AddListener(PlayBackSound);
        _quitButton.onClick.AddListener(PlayQuitSound);
    }

    private void PlayBackSound()
    {
        if (_audioSource && _backSFX)
            _audioSource.PlayOneShot(_backSFX);

        ViewManager.ShowLast();
    }

    private void PlayQuitSound()
    {
        if (_audioSource && _quitSFX)
            _audioSource.PlayOneShot(_quitSFX);

        Application.Quit();
    }
}
