﻿#pragma checksum "..\..\..\AlarmSet.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "978E37B29F8059876D4B2942C42700B06EEE667F1F78699DCFAEDE642099A416"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using CoreTest;
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


namespace CoreTest {
    
    
    /// <summary>
    /// AlarmSet
    /// </summary>
    public partial class AlarmSet : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tab1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid list0;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView list2;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar1;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.DateTimePicker dtstart;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.DateTimePicker dtend;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.ColorPicker colorpicker;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView list1;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\AlarmSet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox list3;
        
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
            System.Uri resourceLocater = new System.Uri("/CoreTest;component/alarmset.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AlarmSet.xaml"
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
            
            #line 6 "..\..\..\AlarmSet.xaml"
            ((CoreTest.AlarmSet)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 6 "..\..\..\AlarmSet.xaml"
            ((CoreTest.AlarmSet)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tab1 = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.list0 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.list2 = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.toolBar1 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 6:
            this.dtstart = ((Microsoft.Windows.Controls.DateTimePicker)(target));
            return;
            case 7:
            this.dtend = ((Microsoft.Windows.Controls.DateTimePicker)(target));
            return;
            case 8:
            this.colorpicker = ((Microsoft.Windows.Controls.ColorPicker)(target));
            
            #line 75 "..\..\..\AlarmSet.xaml"
            this.colorpicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Windows.Media.Color>(this.ColorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.list1 = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.list3 = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

