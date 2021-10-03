using UnityEngine;

public class WeaponManagerV1 : MonoBehaviour
{
    #region Variables

    [SerializeField] private GunV1 _myGun;
    [SerializeField] private MachineGunV1 _myMachineGun;
    [SerializeField] private LaserV1 _myLaser;

    #endregion

    #region MonoBehaviour Callbacks

    private void Start()
    {
        FireAllWeapons();
    }

    #endregion

    #region Other Methods

    private void FireAllWeapons()
    {
        _myGun.Fire(2);
        _myMachineGun.FireMachineGun(2f);
        _myLaser.FireLaser(4f);
    }

    #endregion
}
