using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collections : ScriptableObject
{
    public List<string> collectionList;
    // Start is called before the first frame update
    void Start()
    {
        print(collectionList)
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
