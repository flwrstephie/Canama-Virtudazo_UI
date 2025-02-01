using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _creditsButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _buttonSFX;

    public override void Initialize()
    {
        _playButton.onClick.AddListener(() => PlaySoundAndNavigate<GameMenuView>());
        _settingsButton.onClick.AddListener(() => PlaySoundAndNavigate<SettingsMenuView>());
        _creditsButton.onClick.AddListener(() => PlaySoundAndNavigate<CreditsMenuView>());
        _quitButton.onClick.AddListener(() => PlaySoundAndNavigate<QuitConfirmationView>());
    }

    private void PlaySoundAndNavigate<T>() where T : View
    {
        if (_audioSource && _buttonSFX)
            _audioSource.PlayOneShot(_buttonSFX);
        
        ViewManager.Show<T>();
    }
}
