using UnityEngine;

public class PlayerV3 : MonoBehaviour
{
    #region MonoBehaviour Callbacks

    private void OnTriggerEnter(Collider other)
    {
        var _collectable = other.GetComponent<ICollectableV3>();

        if (_collectable != null)
            _collectable.Collect();
    }

    #endregion
}
