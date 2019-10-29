using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.scripts {

    /// <summary>
    /// A chainsaw launcher
    /// </summary>
    public class ZombieLauncher : Launcher {
        /// <summary>
        /// Use this for initialization
        /// </summary>
        override protected void Start() {
            cooldownSeconds = 0.5f;
            base.Start();
        }
    }
}