using UnityEngine;

public class PlayerV1 : MonoBehaviour
{
    #region Variables

    [SerializeField] private float _playerMaxHealth;
    [SerializeField] private float _playerArmor;
    [SerializeField] private float _playerBullet;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _currentHealth;

    #endregion

    #region MonoBehaviour Callbacks

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ArmorBoostV1>() != null)
        {
            _playerArmor += 5;
            Destroy(other.gameObject);
        }
        else if (other.GetComponent<BulletBoostV1>() != null)
        {
            _playerBullet += 10;
            Destroy(other.gameObject);
        }
        else if (other.GetComponent<HealthBoostV1>() != null)
        {
            _currentHealth += 10;
            _currentHealth = Mathf.Clamp(_currentHealth, 0, _playerMaxHealth);
            Destroy(other.gameObject);
        }
        else if (other.GetComponent<SpeedBoostV1>() != null)
        {
            _playerSpeed += 1;
            Destroy(other.gameObject);
        }
    }

    #endregion
}
