using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using TJ.Infra;

namespace TJ.ScriptableObject.Constants
{
    [CreateAssetMenu(menuName = "Scriptable object/Constants/Module Data")]
    public class ModuleDataSO : UnityEngine.ScriptableObject
    {
        public List<ModuleData> datas;

        public ModuleData Find(string rootModuleName)
            => datas.FirstOrDefault(o => o.moduleName == rootModuleName);
    }
}
