using UnityEngine;

public class ArmorBoostV3 : MonoBehaviour, ICollectableV3
{
    #region Variables

    [SerializeField] private PlayerStatus _playerStatus;
    [SerializeField] private int _additionalArmor;

    #endregion

    #region ICollactableV3

    public void Collect()
    {
        _playerStatus.armor += _additionalArmor;
        Destroy(gameObject);
    }

    #endregion
}
