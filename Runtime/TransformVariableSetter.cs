using UnityEngine;

namespace MGrand.SharedVariables
{
    public class TransformVariableSetter : MonoBehaviour
    {
        [SerializeField]
        private TransformVariableReference variable;

        private void Awake()
        {
            variable.Value = transform;
        }
    }
}