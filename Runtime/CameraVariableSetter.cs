using KBCore.Refs;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace MGrand.SharedVariables
{
    [RequireComponent(typeof(Camera))]
    public class CameraVariableSetter : ValidatedMonoBehaviour
    {
        [SerializeField]
        private CameraVariableReference cameraVariable;

#if ODIN_INSPECTOR
        [FoldoutGroup("Dependencies")]
#endif
        [SerializeField]
        [Self]
        private new Camera camera;

        private void Awake()
        {
            cameraVariable.Value = camera;
        }
    }
}