﻿#pragma checksum "..\..\BaiduIndex.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "374ECDD102C57E0608ACE7BD8FD130BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DevZest.Windows;
using ExtendedGrid.ExtendedColumn;
using ExtendedGrid.ExtendedGridControl;
using ExtendedGrid.Microsoft.Windows.Controls;
using Hammer.SpinningWheel;
using Odyssey.Controls;
using PropertyTools.Wpf;
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
using WpfGauge;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace WpfQuery {
    
    
    /// <summary>
    /// BaiduIndex
    /// </summary>
    public partial class BaiduIndex : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\BaiduIndex.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonQuery;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\BaiduIndex.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExport;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\BaiduIndex.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Hammer.SpinningWheel.SpinningWheel wheel;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\BaiduIndex.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox wtKey;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\BaiduIndex.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PropertyTools.Wpf.ColorPicker cp;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\BaiduIndex.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfGauge.Gauge gauge;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\BaiduIndex.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid edgResult;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfQuery;component/baiduindex.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BaiduIndex.xaml"
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
            this.buttonQuery = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\BaiduIndex.xaml"
            this.buttonQuery.Click += new System.Windows.RoutedEventHandler(this.btQuery);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonExport = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\BaiduIndex.xaml"
            this.buttonExport.Click += new System.Windows.RoutedEventHandler(this.btExport);
            
            #line default
            #line hidden
            return;
            case 3:
            this.wheel = ((Hammer.SpinningWheel.SpinningWheel)(target));
            return;
            case 4:
            this.wtKey = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 5:
            
            #line 66 "..\..\BaiduIndex.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BlueSkinClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 67 "..\..\BaiduIndex.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SilverSkinClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 68 "..\..\BaiduIndex.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BlackSkinClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 75 "..\..\BaiduIndex.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btDefaultThemes);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 80 "..\..\BaiduIndex.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btSystemThemes);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 83 "..\..\BaiduIndex.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btMediaThemes);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cp = ((PropertyTools.Wpf.ColorPicker)(target));
            return;
            case 12:
            
            #line 92 "..\..\BaiduIndex.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btForeground);
            
            #line default
            #line hidden
            return;
            case 13:
            this.gauge = ((WpfGauge.Gauge)(target));
            return;
            case 14:
            this.edgResult = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

