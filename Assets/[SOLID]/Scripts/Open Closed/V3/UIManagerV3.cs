using UnityEngine;
using UnityEngine.UI;

public class UIManagerV3 : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameStatus _gameStatus;
    [SerializeField] private Image _timeBar;

    #endregion

    #region MonoBehaviour Callbacks

    private void Update()
    {
        UpdateTimeBar();
    }

    #endregion

    #region Other Methods

    private void UpdateTimeBar()
    {
        _timeBar.fillAmount = _gameStatus.timer / _gameStatus.maxGameTime;
    }

    #endregion
}
