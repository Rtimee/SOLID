using UnityEngine;

public class LCoinV2 : MonoBehaviour
{
    #region MonoBehaviour Callbacks

    private void OnTriggerEnter(Collider other)
    {
        var _obj = other.GetComponent<ICanCollect>();

        if (_obj != null)
        {
            _obj.Collect();
            Destroy(gameObject);
        }
    }

    #endregion
}
