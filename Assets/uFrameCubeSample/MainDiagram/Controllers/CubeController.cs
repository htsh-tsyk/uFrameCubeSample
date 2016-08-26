using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using uFrame.MVVM;
using uFrame.Kernel;
using uFrame.IOC;
using uFrame.Serialization;


public class CubeController : CubeControllerBase {
    
    public override void InitializeCube(CubeViewModel viewModel) {
        base.InitializeCube(viewModel);
        // This is called when a CubeViewModel is created
    }
}
