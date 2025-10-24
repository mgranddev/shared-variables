using System;
using UnityEngine;

namespace MGrand.SharedVariables
{
    public abstract class SharedVariable<TValue> : ScriptableObject
    {
        [field: NonSerialized]
        public TValue Value { get; set; }
    }
}
