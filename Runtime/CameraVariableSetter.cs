using KBCore.Refs;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MGrand.SharedVariables
{
    [RequireComponent(typeof(Camera))]
    public class CameraVariableSetter : ValidatedMonoBehaviour
    {
        [SerializeField]
        private CameraVariableReference cameraVariable;

        [FoldoutGroup("Dependencies")]
        [SerializeField]
        [Self]
        private new Camera camera;

        private void Awake()
        {
            cameraVariable.Value = camera;
        }
    }
}