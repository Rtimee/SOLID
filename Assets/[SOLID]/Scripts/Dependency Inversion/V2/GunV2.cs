using System.Collections;
using UnityEngine;

public class GunV2 : WeaponV2
{
    #region WeaponV2

    public override void Shoot()
    {
        StartCoroutine(FireWithDelay(_fireCooldown));
    }

    public override void LoadAmmo()
    {
        GameObject _ammo = Instantiate(_ammoPrefab, transform.position, Quaternion.identity);
        _ammo.GetComponent<Rigidbody>().AddForce(transform.forward * 1500);
        Shoot();
    }

    #endregion

    #region Other Methods

    private IEnumerator FireWithDelay(float _delay)
    {
        yield return new WaitForSeconds(_delay);
        LoadAmmo();
    }

    #endregion
}
