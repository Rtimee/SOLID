using UnityEngine;

public abstract class WeaponV2 : MonoBehaviour
{
    #region Variables

    [SerializeField] protected float _fireCooldown;
    [SerializeField] protected GameObject _ammoPrefab;

    #endregion

    #region Abstract Methods

    public abstract void Shoot();
    public abstract void LoadAmmo();

    #endregion
}
