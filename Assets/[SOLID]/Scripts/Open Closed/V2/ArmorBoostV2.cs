using UnityEngine;

public class ArmorBoostV2 : MonoBehaviour,ICollectableV2
{
    public void Collect()
    {
        PlayerV2.Instance.AddArmor();
        Destroy(gameObject);
    }
}
