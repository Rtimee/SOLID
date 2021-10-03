using UnityEngine;

public class PlayerV2 : MonoBehaviour
{
    #region Variables

    public static PlayerV2 Instance;

    [SerializeField] private float _playerMaxHealth;
    [SerializeField] private float _playerArmor;
    [SerializeField] private float _playerBullet;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _currentHealth;

    #endregion

    #region MonoBehaviour Callbacks

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        var _collectable = other.GetComponent<ICollectableV2>();

        if (_collectable != null)
            _collectable.Collect();
    }

    #endregion

    #region Other Methods

    public void HealUp()
    {
        _currentHealth += 10;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _playerMaxHealth);
    }

    public void AddArmor()
    {
        _playerArmor += 5;
    }

    public void AddBullet()
    {
        _playerBullet += 10;
    }

    public void SpeedUp()
    {
        _playerSpeed += 1;
    }

    #endregion
}
