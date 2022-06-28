using UnityEngine;

[ExecuteInEditMode]
public class MeshTransformation : MonoBehaviour
{
    [SerializeField]
    private SkinnedMeshRenderer[] skinnedMeshRenderers;

    [Range(0, 100)]
    public float muscleMass;

    private float prevMuscleMass;

    void Awake()
    {
        prevMuscleMass = muscleMass;
    }

    void Update()
    {
        if (prevMuscleMass != muscleMass)
        {
            prevMuscleMass = muscleMass;

            for(int i = 0; i < skinnedMeshRenderers.Length; i++)
            {
                skinnedMeshRenderers[i].SetBlendShapeWeight(0, 100 - muscleMass);
            }
        }
    }
}