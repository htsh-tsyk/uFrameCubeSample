using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Services;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UniRx;
using UnityEngine;


public class GameView : GameViewBase {
    
    public override uFrame.MVVM.ViewBase CubesCreateView(uFrame.MVVM.ViewModel viewModel) {
		return InstantiateView(viewModel, new Vector3(250, 250, 250));
    }
    
    public override void CubesAdded(uFrame.MVVM.ViewBase view) {
    }
    
    public override void CubesRemoved(uFrame.MVVM.ViewBase view) {
    }
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as GameViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.Game to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
    }
}
