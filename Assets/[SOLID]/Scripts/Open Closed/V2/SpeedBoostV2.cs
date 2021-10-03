using UnityEngine;

public class SpeedBoostV2 : MonoBehaviour,ICollectableV2
{
    public void Collect()
    {
        PlayerV2.Instance.SpeedUp();
        Destroy(gameObject);
    }
}
