﻿#pragma checksum "..\..\SolutionsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3208231EFAF0491625050B11D3C6B538A4C82F4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using TouristAssistSistem;


namespace TouristAssistSistem {
    
    
    /// <summary>
    /// SolutionsPage
    /// </summary>
    public partial class SolutionsPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\SolutionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\SolutionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\SolutionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelRoom;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\SolutionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nameRommUI;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SolutionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock descrRoomUI;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\SolutionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelRoutes;
        
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
            System.Uri resourceLocater = new System.Uri("/TouristAssistSistem;component/solutionspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SolutionsPage.xaml"
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
            
            #line 3 "..\..\SolutionsPage.xaml"
            ((TouristAssistSistem.SolutionsPage)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.windowMovingEvent);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\SolutionsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.closePageEvent);
            
            #line default
            #line hidden
            return;
            case 3:
            this.StackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.label = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.StackPanelRoom = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.nameRommUI = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.descrRoomUI = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.StackPanelRoutes = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

