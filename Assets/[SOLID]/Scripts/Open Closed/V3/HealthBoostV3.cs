using UnityEngine;

public class HealthBoostV3 : MonoBehaviour, ICollectableV3
{
    #region Variables

    [SerializeField] private PlayerStatus _playerStatus;
    [SerializeField] private int _additionalHealth;

    #endregion

    #region ICollactableV3

    public void Collect()
    {
        _playerStatus.currentHp = Mathf.Clamp(_playerStatus.currentHp + _additionalHealth, 0, _playerStatus.maxHp);
        Destroy(gameObject);
    }

    #endregion
}
