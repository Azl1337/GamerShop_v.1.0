﻿#pragma checksum "..\..\..\Pages\AdminMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DC66028FFACC248D1E51FF2DDA090325090AE71916EE1D580EE1A8661522F8ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GamerShop_v1._0.Pages;
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


namespace GamerShop_v1._0.Pages {
    
    
    /// <summary>
    /// AdminMenu
    /// </summary>
    public partial class AdminMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Pages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProfile;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCatalog;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStorySelles;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClient;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPublishers;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDevelopers;
        
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
            System.Uri resourceLocater = new System.Uri("/GamerShop v1.0;component/pages/adminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AdminMenu.xaml"
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
            this.BtnProfile = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Pages\AdminMenu.xaml"
            this.BtnProfile.Click += new System.Windows.RoutedEventHandler(this.BtnProfileClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnCatalog = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\AdminMenu.xaml"
            this.BtnCatalog.Click += new System.Windows.RoutedEventHandler(this.BtnCatalogClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnStorySelles = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\AdminMenu.xaml"
            this.BtnStorySelles.Click += new System.Windows.RoutedEventHandler(this.BtnStoryClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnClient = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\AdminMenu.xaml"
            this.BtnClient.Click += new System.Windows.RoutedEventHandler(this.BtnClientClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnPublishers = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Pages\AdminMenu.xaml"
            this.BtnPublishers.Click += new System.Windows.RoutedEventHandler(this.BtnPublisherClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnDevelopers = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\AdminMenu.xaml"
            this.BtnDevelopers.Click += new System.Windows.RoutedEventHandler(this.BtnDeveloperClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

