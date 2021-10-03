using UnityEngine;

public class BulletBoostV3 : MonoBehaviour,ICollectableV3
{
    #region Variables

    [SerializeField] private PlayerStatus _playerStatus;
    [SerializeField] private int _additionalBullet;

    #endregion

    #region ICollactableV3

    public void Collect()
    {
        _playerStatus.bulletCount += _additionalBullet;
        Destroy(gameObject);
    }

    #endregion
}
