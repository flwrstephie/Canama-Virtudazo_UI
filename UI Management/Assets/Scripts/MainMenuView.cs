using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _creditsButton;
    [SerializeField] private Button _quitButton;

    public override void Initialize()
    {
        _settingsButton.onClick.AddListener(() => ViewManager.Show<SettingsMenuView>());
        _creditsButton.onClick.AddListener(() => ViewManager.Show<CreditsMenuView>());
        _quitButton.onClick.AddListener(() => ViewManager.Show<QuitConfirmationView>()); // Opens quit confirmation instead of quitting immediately
    }
}
