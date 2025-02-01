using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;
    [SerializeField] private AudioSource _bgmSource;
    [SerializeField] private AudioSource _sfxSource;

    private float _mainVolume = 1f;
    private float _bgmVolume = 1f;
    private float _sfxVolume = 1f;

    public static AudioManager Instance => _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (_bgmSource && !_bgmSource.isPlaying)
        {
            _bgmSource.loop = true;
            _bgmSource.Play();
        }
    }

    public void SetMainVolume(float value)
    {
        _mainVolume = value;
        _bgmSource.volume = _bgmVolume * _mainVolume;
        _sfxSource.volume = _sfxVolume * _mainVolume;
    }

    public void SetBGMVolume(float value)
    {
        _bgmVolume = value;
        _bgmSource.volume = _bgmVolume * _mainVolume;
    }

    public void SetSFXVolume(float value)
    {
        _sfxVolume = value;
        _sfxSource.volume = _sfxVolume * _mainVolume;
    }

    public float GetMainVolume()
    {
        return _mainVolume;
    }

    public float GetBGMVolume()
    {
        return _bgmVolume;
    }

    public float GetSFXVolume()
    {
        return _sfxVolume;
    }
}
