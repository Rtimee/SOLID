using UnityEngine;

public class Player : LCharacterV2, IRunnable, ICanCollect
{
    #region Varibles

    private int _cointCount;

    #endregion

    #region LCharacterV2

    public override void MoveForward()
    {
        Run();
    }

    #endregion

    #region IRunnable

    public void Run()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }

    #endregion

    #region ICanCollect

    public void Collect()
    {
        _cointCount++;
    }

    #endregion
}

