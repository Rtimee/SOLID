using UnityEngine;

public class WeaponManagerV2 : MonoBehaviour
{
    #region Variables

    [SerializeField] private WeaponV2[] _myWeapons;

    #endregion

    #region MonoBehaviour Callbacks

    private void Start()
    {
        ActivateAllWeapons();
    }

    #endregion

    #region Other Methods

    private void ActivateAllWeapons()
    {
        for (int i = 0; i < _myWeapons.Length; i++)
        {
            _myWeapons[i].Shoot();
        }
    }

    #endregion
}
