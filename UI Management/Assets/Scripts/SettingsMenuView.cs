using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuView : View
{
    [SerializeField] private Button _backButton;
    [SerializeField] private AudioSource _bgmSource;
    [SerializeField] private AudioSource _sfxSource;
    [SerializeField] private AudioClip _backSFX;
    [SerializeField] private AudioClip _sfxAdjustmentSFX;  

    [SerializeField] private Slider _mainVolumeSlider;
    [SerializeField] private Slider _bgmVolumeSlider;
    [SerializeField] private Slider _sfxVolumeSlider;

    public override void Initialize()
    {
        _backButton.onClick.AddListener(PlayBackSound);

        
        _mainVolumeSlider.value = AudioManager.Instance.GetMainVolume();
        _bgmVolumeSlider.value = AudioManager.Instance.GetBGMVolume();
        _sfxVolumeSlider.value = AudioManager.Instance.GetSFXVolume();

        
        _mainVolumeSlider.onValueChanged.AddListener(UpdateMainVolume);
        _bgmVolumeSlider.onValueChanged.AddListener(UpdateBGMVolume);
        _sfxVolumeSlider.onValueChanged.AddListener(UpdateSFXVolume);
    }

    private void PlayBackSound()
    {
        if (_bgmSource && _backSFX)
            _bgmSource.PlayOneShot(_backSFX);

        ViewManager.ShowLast();
    }

    private void UpdateMainVolume(float value)
    {
        
        _bgmSource.volume = value;
        _sfxSource.volume = value;
        AudioManager.Instance.SetMainVolume(value);
    }

    private void UpdateBGMVolume(float value)
    {
        _bgmSource.volume = value;
        AudioManager.Instance.SetBGMVolume(value);
    }

    private void UpdateSFXVolume(float value)
    {
        _sfxSource.volume = value;
        AudioManager.Instance.SetSFXVolume(value);

        
        if (_sfxAdjustmentSFX && _sfxSource)
        {
            _sfxSource.PlayOneShot(_sfxAdjustmentSFX);
        }
    }
}
