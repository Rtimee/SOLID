using UnityEngine;

public class LObstacleV2 : MonoBehaviour
{
    #region MonoBehaviour Callbacks

    private void OnTriggerEnter(Collider other)
    {
        var _obj = other.GetComponent<LCharacterV2>();

        if(_obj != null)
        {
            _obj.Hit();
            Destroy(gameObject);
        }
    }

    #endregion
}
