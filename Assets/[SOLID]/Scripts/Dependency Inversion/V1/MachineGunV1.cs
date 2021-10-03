using System.Collections;
using UnityEngine;

public class MachineGunV1 : MonoBehaviour
{
    #region Other Methods

    public void FireMachineGun(float _delay)
    {
        StartCoroutine(FireWithDelay(_delay));
    }

    private IEnumerator FireWithDelay(float _delay)
    {
        yield return new WaitForSeconds(_delay);
        Debug.Log("Gun Fired!");
    }

    #endregion
}
