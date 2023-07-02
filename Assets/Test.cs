using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MyType
{
    Player = 0,
    Enemy
}

public class Test : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> itemList = new List<GameObject>();

    [SerializeField]
    private Dictionary<string, GameObject> monsList = new Dictionary<string, GameObject>();

    [SerializeField]
    private MyType type;

    [SerializeField]
    private int id;

    private void Start()
    {
        Attack(type);
        GameObject item = Instantiate(Resources.Load<GameObject>("Player"));
        monsList.Add("Player", item);
        Destroy(item, 1f);
        itemList.Add(item);
    }

    private void OnDestroy()
    {
        itemList.Remove(gameObject);
    }

    public void Attack(MyType _type)
    {
        switch(_type)
        {
            case MyType.Player: Debug.Log("awdawd"); break;
            case MyType.Enemy: Debug.Log("awdawd"); break;
        }
    }
}