﻿#pragma checksum "..\..\..\Pages\UserProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD2D9A2A9276221DAF8E528668355E4BBD2FDFAF327C770648EA43CAAD7F34FC"
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
    /// UserProfile
    /// </summary>
    public partial class UserProfile : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\Pages\UserProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelLogin;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\UserProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxLastName;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\UserProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxName;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\UserProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxPatronymic;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\UserProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChangeInfo;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\UserProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LBoxGame;
        
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
            System.Uri resourceLocater = new System.Uri("/GamerShop v1.0;component/pages/userprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\UserProfile.xaml"
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
            
            #line 10 "..\..\..\Pages\UserProfile.xaml"
            ((GamerShop_v1._0.Pages.UserProfile)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.PageIsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelLogin = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.TBoxLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBoxPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtnChangeInfo = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Pages\UserProfile.xaml"
            this.BtnChangeInfo.Click += new System.Windows.RoutedEventHandler(this.BtnChangeInfoClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LBoxGame = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
