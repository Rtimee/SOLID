using UnityEngine;

public class HealthBoostV2 : MonoBehaviour,ICollectableV2
{
    public void Collect()
    {
        PlayerV2.Instance.HealUp();
        Destroy(gameObject);
    }
}
