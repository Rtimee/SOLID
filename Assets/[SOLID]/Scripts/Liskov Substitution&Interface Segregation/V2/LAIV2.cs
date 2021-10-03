using UnityEngine;

public class LAIV2 : LCharacterV2,IRunnable
{
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
}
