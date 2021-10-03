using UnityEngine;

public abstract class LCharacterV2 : MonoBehaviour
{
    #region Variables

    [SerializeField] protected float _speed;
    [SerializeField] protected float _health;

    #endregion

    #region MonoBehaviour Callbacks

    private void Update()
    {
        MoveForward();
    }

    #endregion

    #region Abstract Methods

    public abstract void MoveForward();

    #endregion

    #region Other Methods

    public void Hit()
    {
        _health--;
        Debug.Log(gameObject.name + "'s Heath: " + _health);
    }

    #endregion
}
