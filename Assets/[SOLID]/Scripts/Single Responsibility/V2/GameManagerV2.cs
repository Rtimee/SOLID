using UnityEngine;

public class GameManagerV2 : MonoBehaviour
{
    #region Variables

    public bool isGameStarted;

    private int _coinCount;
    private float _gameTime;

    #endregion

    #region MonoBehaviour Callbacks

    private void Update()
    {
        if (!isGameStarted)
            return;

        _gameTime += Time.deltaTime;
    }

    #endregion

    #region Other Methods

    public void StartGame()
    {
        isGameStarted = true;
        _gameTime = 0;
    }

    public void FinishLevel()
    {
        isGameStarted = false;
    }

    public void AddCoin()
    {
        _coinCount++;
    }

    #endregion
}
