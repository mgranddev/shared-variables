using System;
using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace MGrand.SharedVariables
{
    [Serializable]
#if ODIN_INSPECTOR
    [InlineProperty]
    public abstract class SharedVariableReference<TValue, TVariable> : ISelfValidator where TVariable : SharedVariable<TValue>
#else
    public abstract class SharedVariableReference<TValue, TVariable> where TVariable : SharedVariable<TValue>
#endif
    {
        [SerializeField]
#if ODIN_INSPECTOR
        [HideLabel]
        [HorizontalGroup(Width = 70)]
#endif
        private ValueSource source;

        [SerializeField]
#if ODIN_INSPECTOR
        [HideIf("@source != ValueSource.Local", false)]
        [HideLabel]
        [HorizontalGroup]
#endif
        private TValue value;

        [SerializeField]
#if ODIN_INSPECTOR
        [HideIf("@source != ValueSource.Shared", false)]
        [HideLabel]
        [HorizontalGroup]
#endif
        private TVariable variable;

        public TValue Value
        {
            get
            {
                return source switch
                {
                    ValueSource.Local => value,
                    ValueSource.Shared => variable.Value,
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
            set
            {
                switch (source)
                {
                    case ValueSource.Local:
                        this.value = value;
                        break;
                    case ValueSource.Shared:
                        variable.Value = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

#if ODIN_INSPECTOR
        public void Validate(SelfValidationResult result)
        {
            if (source == ValueSource.Shared && variable == null) result.AddError("Variable is required.");
        }
#endif
    }
}
