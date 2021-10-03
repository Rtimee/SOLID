using System.Collections;
using UnityEngine;

public class LaserV2 : WeaponV2
{
    #region Variables

    [SerializeField] private float _laserActiveTime;

    #endregion

    #region WeaponV2

    public override void Shoot()
    {
        StartCoroutine(FireWithDelay(_fireCooldown, _laserActiveTime));
    }

    public override void LoadAmmo()
    {
        _ammoPrefab.SetActive(true);
    }

    #endregion

    #region Other Methods

    private IEnumerator FireWithDelay(float _delay, float _activeTime)
    {
        yield return new WaitForSeconds(_delay);
        LoadAmmo();
        yield return new WaitForSeconds(_activeTime);
        WaitForFire();
        Shoot();
    }

    private void WaitForFire()
    {
        _ammoPrefab.SetActive(false);
    }

    #endregion
}
