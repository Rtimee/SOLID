using System.Collections;
using UnityEngine;

public class LaserV1 : MonoBehaviour
{
    #region Other Methods

    public void FireLaser(float _delay)
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
