﻿#pragma checksum "..\..\..\Pages\AddOrEditDeveloper.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "251BF49694C551755C7842EC0513F229D6DC7397359997651460EF6C1E4F1AAF"
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
    /// AddOrEditDeveloper
    /// </summary>
    public partial class AddOrEditDeveloper : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Pages\AddOrEditDeveloper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\AddOrEditDeveloper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\AddOrEditDeveloper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxLastName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\AddOrEditDeveloper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AddOrEditDeveloper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPickerCompanyWasFounded;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\AddOrEditDeveloper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOK;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\AddOrEditDeveloper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/GamerShop v1.0;component/pages/addoreditdeveloper.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddOrEditDeveloper.xaml"
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
            
            #line 9 "..\..\..\Pages\AddOrEditDeveloper.xaml"
            ((GamerShop_v1._0.Pages.AddOrEditDeveloper)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.PageIsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBoxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBoxPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBoxLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DPickerCompanyWasFounded = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.BtnOK = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Pages\AddOrEditDeveloper.xaml"
            this.BtnOK.Click += new System.Windows.RoutedEventHandler(this.BtnOkClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Pages\AddOrEditDeveloper.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancelClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
