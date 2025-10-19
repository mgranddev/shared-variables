using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MGrand.SharedVariables
{
    [Serializable]
    [InlineProperty]
    public abstract class SharedVariableReference<TValue, TVariable> : ISelfValidator where TVariable : SharedVariable<TValue>
    {
        [SerializeField]
        [HideLabel]
        [HorizontalGroup(Width = 70)]
        private ValueSource source;

        [SerializeField]
        [HideIf("@source != ValueSource.Local", false)]
        [HideLabel]
        [HorizontalGroup]
        private TValue value;

        [SerializeField]
        [HideIf("@source != ValueSource.Shared", false)]
        [HideLabel]
        [HorizontalGroup]
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

        public void Validate(SelfValidationResult result)
        {
            if (source == ValueSource.Shared && variable == null) result.AddError("Variable is required.");
        }
    }
}