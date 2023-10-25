using System;
using HNK.Tools;
using UnityEngine;

namespace TestScenes.Singleton {
    public class SingletonInheritor : Singleton<SingletonInheritor> {
        private void Start() {
            if (Instance != null) {
                Debug.Log(typeof(SingletonInheritor) + " is alive!");
            }
        }
    }
}