using UnityEngine;

public class LFlyingPlayerV2 : LCharacterV2, IFlyable, ICanCollect
{
    #region Variables

    [SerializeField] private float _flySpeed;

    private int _coinCount;

    #endregion

    #region LCharacterV2

    public override void MoveForward()
    {
        Fly();
    }

    #endregion

    #region IFlyable

    public void Fly()
    {
        transform.Translate((transform.forward * _speed + transform.up * _flySpeed) * Time.deltaTime);
    }

    #endregion

    #region ICanCollect

    public void Collect()
    {
        _coinCount++;
    }

    #endregion
}
