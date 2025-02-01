using UnityEngine;
using UnityEngine.UI;

public class GameMenuView : View
{
    [SerializeField] private Button _backButton;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _backSFX;

    public override void Initialize()
    {
        _backButton.onClick.AddListener(PlayBackSound);
    }

    private void PlayBackSound()
    {
        if (_audioSource && _backSFX)
            _audioSource.PlayOneShot(_backSFX);

        ViewManager.ShowLast();
    }
}
