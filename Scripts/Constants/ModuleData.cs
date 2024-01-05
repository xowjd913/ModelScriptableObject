using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TJ.Infra
{
    public class ModuleData
    {
        public string RootModuleResourceName { get; }
        public List<ModuleData> SubModuleResourceNames { get; }

        public int Order { get; }

        public ModuleData(string rootModuleResource, List<ModuleData> subModuleResources, int order)
        {
            this.RootModuleResourceName = rootModuleResource;
            this.SubModuleResourceNames = subModuleResources;
            this.Order = order;
        }

        public static implicit operator bool(ModuleData m)
            => m != null;
    }

}
