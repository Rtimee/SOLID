using UnityEngine;
using UnityEngine.UI;

public class GameManagerV1 : MonoBehaviour
{
    #region Variables

    public bool isGameStarted;

    [SerializeField] private GameObject _startScreen;
    [SerializeField] private GameObject _gameScreen;
    [SerializeField] private GameObject _finishScreen;
    [SerializeField] private Text _scoreText;
    [SerializeField] private AudioSource _coinSound;
    [SerializeField] private AudioSource _mainGameMusic;

    private float _gameTime;
    private int _cointCount;

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
        _mainGameMusic.Play();
        _startScreen.SetActive(false);
        _gameScreen.SetActive(true);
    }

    public void CollectCoin()
    {
        _cointCount++;
        _coinSound.Play();
        _scoreText.text = "Score: " + _cointCount * 10;
    }

    public void FinishLevel()
    {
        isGameStarted = false;
        _gameScreen.SetActive(false);
        _finishScreen.SetActive(true);
    }

    #endregion
}
