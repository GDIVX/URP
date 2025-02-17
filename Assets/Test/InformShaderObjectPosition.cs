using UnityEngine;

namespace Test
{
    public class InformShaderObjectPosition : MonoBehaviour
    {
        private static readonly int TargetPosition = Shader.PropertyToID("_TargetPosition");

        private void Update()
        {
            if (TargetPosition <= 0)
            {
                Debug.Log("Wrong property name");
            }
            Shader.SetGlobalVector(TargetPosition,
                new Vector3(transform.position.x, transform.position.y, transform.position.z));
        }
    }
}