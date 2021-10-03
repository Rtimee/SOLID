 using UnityEngine;

public class LPlayerV1 : MonoBehaviour
{
    #region Variables

    [SerializeField] private float _runSpeed;
    [SerializeField] private float _health;

    private int _coinCount;

    #endregion

    #region MonoBehaviour Callbacks

    private void Update()
    {
        Run();
    }

    #endregion

    #region Other Methods

    private void Run()
    {
        transform.Translate(transform.forward * _runSpeed * Time.deltaTime);
    }

    private void Hit()
    {
        _health--;
    }

    public void CollectCoin(int _amount)
    {
        _coinCount += _amount;
    }

    #endregion
}
