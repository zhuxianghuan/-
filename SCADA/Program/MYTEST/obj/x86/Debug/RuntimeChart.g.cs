﻿#pragma checksum "..\..\..\RuntimeChart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D5E133AF003281A6B18F0DD0E99ED4BAFF551A5A28A73F68F3DDBBABBA99524A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes.Numeric;
using Microsoft.Research.DynamicDataDisplay.Charts.Isolines;
using Microsoft.Research.DynamicDataDisplay.Charts.Markers;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay.Charts.Shapes;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.Converters;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.MarkupExtensions;
using Microsoft.Research.DynamicDataDisplay.Navigation;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.ViewportRestrictions;
using Microsoft.Windows.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MYTEST {
    
    
    /// <summary>
    /// RuntimeChart
    /// </summary>
    public partial class RuntimeChart : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\RuntimeChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comb1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\RuntimeChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.ColorPicker colorpicker;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\RuntimeChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.ChartPlotter chartPlotter1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\RuntimeChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.HorizontalDateTimeAxis hTimeSpanAxis;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\RuntimeChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.HorizontalLine hilevel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\RuntimeChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.HorizontalLine lolevel;
        
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
            System.Uri resourceLocater = new System.Uri("/MYTEST;component/runtimechart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RuntimeChart.xaml"
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
            
            #line 8 "..\..\..\RuntimeChart.xaml"
            ((MYTEST.RuntimeChart)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\RuntimeChart.xaml"
            ((MYTEST.RuntimeChart)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comb1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\RuntimeChart.xaml"
            this.comb1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comb1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.colorpicker = ((Microsoft.Windows.Controls.ColorPicker)(target));
            
            #line 18 "..\..\..\RuntimeChart.xaml"
            this.colorpicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Windows.Media.Color>(this.ColorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chartPlotter1 = ((Microsoft.Research.DynamicDataDisplay.ChartPlotter)(target));
            return;
            case 5:
            this.hTimeSpanAxis = ((Microsoft.Research.DynamicDataDisplay.Charts.HorizontalDateTimeAxis)(target));
            return;
            case 6:
            this.hilevel = ((Microsoft.Research.DynamicDataDisplay.Charts.HorizontalLine)(target));
            return;
            case 7:
            this.lolevel = ((Microsoft.Research.DynamicDataDisplay.Charts.HorizontalLine)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

