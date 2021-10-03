using UnityEngine;

public class GameManagerV3 : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameStatus _gameStatus;

    #endregion

    #region MonoBehaviour Callbacks

    private void Update()
    {
        _gameStatus.timer -= Time.deltaTime;
    }

    private void OnApplicationQuit()
    {
        _gameStatus.timer = _gameStatus.maxGameTime;
    }

    #endregion
}
