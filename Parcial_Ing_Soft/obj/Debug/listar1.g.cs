﻿#pragma checksum "..\..\listar1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9CE0B12A06CBDCC7649B8AF52FE2D18C73054C74"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Parcial_Ing_Soft;
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


namespace Parcial_Ing_Soft {
    
    
    /// <summary>
    /// listar1
    /// </summary>
    public partial class listar1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\listar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_situacion;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\listar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_tipo;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\listar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_barrios;
        
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
            System.Uri resourceLocater = new System.Uri("/Parcial_Ing_Soft;component/listar1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\listar1.xaml"
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
            this.cmb_situacion = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\listar1.xaml"
            this.cmb_situacion.Loaded += new System.Windows.RoutedEventHandler(this.cmb_situacion_loaded);
            
            #line default
            #line hidden
            
            #line 47 "..\..\listar1.xaml"
            this.cmb_situacion.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_situacion_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmb_tipo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\listar1.xaml"
            this.cmb_tipo.Loaded += new System.Windows.RoutedEventHandler(this.cmb_tipo_loaded);
            
            #line default
            #line hidden
            
            #line 50 "..\..\listar1.xaml"
            this.cmb_tipo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_tipo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmb_barrios = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\listar1.xaml"
            this.cmb_barrios.Loaded += new System.Windows.RoutedEventHandler(this.cmb_barrios_loaded);
            
            #line default
            #line hidden
            
            #line 53 "..\..\listar1.xaml"
            this.cmb_barrios.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_barrios_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 60 "..\..\listar1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.consulta);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 69 "..\..\listar1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.agregar_volver_atras);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

