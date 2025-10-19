using System;
using UnityEngine;

namespace MGrand.SharedVariables
{
    // TODO: This should be in a "Variables" folder, maybe with its own assembly.
    public abstract class SharedVariable<TValue> : ScriptableObject
    {
        [field: NonSerialized]
        public TValue Value { get; set; }
    }
}