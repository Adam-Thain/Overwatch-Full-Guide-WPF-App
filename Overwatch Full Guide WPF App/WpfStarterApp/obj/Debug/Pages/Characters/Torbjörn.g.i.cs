﻿#pragma checksum "..\..\..\..\Pages\Characters\Torbjörn.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80BF36AC0160300E81F15C1B59D9EF2252A220B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfStarterApp.Pages;


namespace WpfStarterApp.Pages {
    
    
    /// <summary>
    /// Torbjörn
    /// </summary>
    public partial class Torbjörn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Pages\Characters\Torbjörn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame CharacterStatsBox;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\Pages\Characters\Torbjörn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameHolder;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Pages\Characters\Torbjörn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame CharacterSelectFrame;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Pages\Characters\Torbjörn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToCharacterSelect;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfStarterApp;component/pages/characters/torbj%c3%b6rn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Characters\Torbjörn.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CharacterStatsBox = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.FrameHolder = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.CharacterSelectFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            this.BackToCharacterSelect = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\..\..\Pages\Characters\Torbjörn.xaml"
            this.BackToCharacterSelect.Click += new System.Windows.RoutedEventHandler(this.BtnClickCharacterSelect);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

