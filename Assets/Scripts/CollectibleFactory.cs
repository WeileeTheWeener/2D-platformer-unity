using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleFactory : MonoBehaviour
{
    public ParticleComponent particleComponent;
    public LevelManagerComponent levelManager;
    public GameObject collectiblePrefab;
    public List<Vector3> positions;
    public List<GameObject> collectibleInstances;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var position in positions)
        {
            GameObject instance =  Instantiate(collectiblePrefab);
            instance.transform.position = position;
            instance.GetComponent<CollectibleComponent>().onCollected.AddListener(particleComponent.ExplodeParticles);
            collectibleInstances.Add(instance);
        }
        
    }
 
}
