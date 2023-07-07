using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleFactory : MonoBehaviour
{
    //todo : privatea cek
    [SerializeField] private ParticleComponent particleComponent;
    [SerializeField] private GameObject collectiblePrefab;
    [SerializeField] private List<Vector3> positions;
    [SerializeField] private List<GameObject> collectibleInstances;

    public List<Vector3> Positions { get => positions; set => positions = value; }
    public List<GameObject> CollectibleInstances { get => collectibleInstances; set => collectibleInstances = value; }

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
