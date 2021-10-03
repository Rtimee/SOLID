using UnityEngine;

public class LCoinV1 : MonoBehaviour
{
    #region MonoBehaviour Callbacks

    private void OnTriggerEnter(Collider other)
    {
        var _player = other.GetComponent<LPlayerV1>();

        if(_player != null)
        {
            if (_player is LFylingPlayerV1)
            {
                _player.CollectCoin(2);
            }
            else if (_player is AI)
            {
                _player.CollectCoin(0);
            }
        }
    }

    #endregion
}
