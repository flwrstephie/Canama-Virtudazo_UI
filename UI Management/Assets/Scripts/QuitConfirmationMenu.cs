using UnityEngine;
using UnityEngine.UI;

public class QuitConfirmationView : View
{
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _quitButton;

    public override void Initialize()
    {
        _backButton.onClick.AddListener(() => ViewManager.ShowLast());
        _quitButton.onClick.AddListener(QuitGame);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
