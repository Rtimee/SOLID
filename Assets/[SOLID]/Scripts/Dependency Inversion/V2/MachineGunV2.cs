using System.Collections;
using UnityEngine;

public class MachineGunV2 : WeaponV2
{
    #region Variables

    [SerializeField] private int _bulletCountOnFire;
    [SerializeField] private float _fireCooldownBetweenBullets;

    #endregion

    #region WeaponV2

    public override void Shoot()
    {
        StartCoroutine(FireWithDelay(_fireCooldown, _bulletCountOnFire));
    }

    public override void LoadAmmo()
    {
        GameObject _ammo = Instantiate(_ammoPrefab, transform.position, Quaternion.identity);
        _ammo.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }

    #endregion

    #region Other Methods

    private IEnumerator FireWithDelay(float _delay, float _bulletcount)
    {
        yield return new WaitForSeconds(_delay);

        int i = 0;
        for (i = 0; i < _bulletcount; i++)
        {
            LoadAmmo();
            yield return new WaitForSeconds(_fireCooldownBetweenBullets);
        }
        if (i == _bulletcount)
            Shoot();
    }

    #endregion
}
