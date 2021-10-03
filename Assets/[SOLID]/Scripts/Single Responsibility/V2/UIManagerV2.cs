using UnityEngine;
using UnityEngine.UI;

public class UIManagerV2 : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameObject _startScreen;
    [SerializeField] private GameObject _gameScreen;
    [SerializeField] private GameObject _finalScreen;
    [SerializeField] private Text _scoreText;

    #endregion

    #region Other Methods

    public void ShowStartGameUI()
    {
        _startScreen.SetActive(false);
        _gameScreen.SetActive(true);
    }

    public void ShowLevelEndUI()
    {
        _gameScreen.SetActive(false);
        _finalScreen.SetActive(true);
    }

    public void UpdateScoreText(int _cointCount)
    {
        _scoreText.text = "Score: " + _cointCount * 10;
    }

    #endregion
}
