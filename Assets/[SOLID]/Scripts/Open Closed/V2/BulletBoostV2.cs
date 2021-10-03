using UnityEngine;

public class BulletBoostV2 : MonoBehaviour,ICollectableV2
{
    public void Collect()
    {
        PlayerV2.Instance.AddBullet();
        Destroy(gameObject);
    }
}
