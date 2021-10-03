using UnityEngine;

public class SpeedBoostV3 : MonoBehaviour, ICollectableV3
{
    #region Variables

    [SerializeField] private PlayerStatus _playerStatus;
    [SerializeField] private int _additionalSpeed;

    #endregion

    #region ICollactableV3

    public void Collect()
    {
        _playerStatus.speed += _additionalSpeed;
        Destroy(gameObject);
    }

    #endregion
}
