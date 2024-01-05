using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TJ.ScriptableObject.Model
{
    //[CreateAssetMenu(menuName = "Scriptable object/Models/Base Model Data")]
    public abstract class ModelSO<T> : UnityEngine.ScriptableObject
    {
        [field: NonSerialized] public bool IsCallingManualPropertyChangedCallback { get; set; } = false;
        public string targetViewModelName;

        protected UnityEvent<string, T> onPropertyChanged;

        public void OnPropertyChanged(UnityAction<string, T> onPropertyChanged)
            => this.onPropertyChanged.AddListener(onPropertyChanged);

        public void RemovePropertyChanged(UnityAction<string, T> onPropertyChanged)
            => this.onPropertyChanged.RemoveListener(onPropertyChanged);

        public void RaiseEvent(string eventName, T source)
            => this.onPropertyChanged.Invoke(eventName, source);

        public abstract string ToJson();
    }

}
