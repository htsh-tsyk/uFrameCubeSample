using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using uFrame.MVVM;
using uFrame.Kernel;
using uFrame.IOC;
using uFrame.Serialization;


public class GameController : GameControllerBase {
    
    public override void InitializeGame(GameViewModel viewModel) {
        base.InitializeGame(viewModel);
        // This is called when a GameViewModel is created
    }
    
    public override void AddCube(GameViewModel viewModel) {
		CubeViewModel cubeViewModel = this.CreateViewModel<CubeViewModel> ();
		viewModel.Cubes.Add (cubeViewModel);
        base.AddCube(viewModel);
    }
}
