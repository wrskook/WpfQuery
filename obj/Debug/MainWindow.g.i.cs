﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "34E1291813FFD3142B398F8740E31C00"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent;
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
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Layout;
using Xceed.Wpf.AvalonDock.Themes;


namespace WpfQuery {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfQuery.MainWindow window;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Ribbon ribbon;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnSkin;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.AvalonDock.DockingManager dockManager;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser defaultBrowser;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfQuery;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.window = ((WpfQuery.MainWindow)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.window.Closed += new System.EventHandler(this.window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ribbon = ((Fluent.Ribbon)(target));
            return;
            case 3:
            
            #line 31 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnExitSystem);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLogin = ((Fluent.Button)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.Login);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 41 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Setting);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 42 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.About);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSkin = ((Fluent.Button)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.btnSkin.Click += new System.Windows.RoutedEventHandler(this.SkinClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 46 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnExitSystem);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 53 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IncludeQuery);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 54 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RankQuery);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 55 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TitleQuery);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 56 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RankStat);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 59 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PlatformQuery);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 60 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConditionQuery);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 61 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.KeyCover);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 64 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BasicInfo);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 65 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LogParser);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 68 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.KeyDig);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 69 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SentenceSplit);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 70 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Post);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 71 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Gather);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 72 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DownloadWeb);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 73 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Downword);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 74 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RelatedSearch);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 80 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BaiduIndex);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 81 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.KeywordAnalyze);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 87 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IISConfig);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 88 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ping);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 94 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BaiduAccount);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 97 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BDKeywordRecommend);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 98 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreativeCollection);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 101 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BDWMInterest);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 104 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SogouAccount);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 105 "..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SogouKRService);
            
            #line default
            #line hidden
            return;
            case 35:
            this.dockManager = ((Xceed.Wpf.AvalonDock.DockingManager)(target));
            return;
            case 36:
            this.defaultBrowser = ((System.Windows.Controls.WebBrowser)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

