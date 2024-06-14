
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateSpike();
    }

    void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
