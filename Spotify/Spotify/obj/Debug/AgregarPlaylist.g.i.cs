﻿#pragma checksum "..\..\AgregarPlaylist.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6E4F30FED5E8CEB0F8F0B609919B4696DE2D7CA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Spotify;
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


namespace Spotify {
    
    
    /// <summary>
    /// AgregarPlaylist
    /// </summary>
    public partial class AgregarPlaylist : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AgregarPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AgregarPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AgregarPlaylist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrear;
        
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
            System.Uri resourceLocater = new System.Uri("/Spotify;component/agregarplaylist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AgregarPlaylist.xaml"
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
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\AgregarPlaylist.xaml"
            this.txtNombre.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNombre_TextChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\AgregarPlaylist.xaml"
            this.txtNombre.GotFocus += new System.Windows.RoutedEventHandler(this.txtNombre_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\AgregarPlaylist.xaml"
            this.txtDescripcion.GotFocus += new System.Windows.RoutedEventHandler(this.txtDescripcion_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AgregarPlaylist.xaml"
            this.btnCrear.Click += new System.Windows.RoutedEventHandler(this.btnCrear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
