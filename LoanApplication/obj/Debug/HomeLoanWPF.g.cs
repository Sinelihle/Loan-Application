﻿#pragma checksum "..\..\HomeLoanWPF.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AFB63DE20A0B76B1C890EA2DE2093F7D0DB6371156DADF3E9ADE4605D9EF3B46"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoanApplication;
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


namespace LoanApplication {
    
    
    /// <summary>
    /// HomeLoanWPF
    /// </summary>
    public partial class HomeLoanWPF : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGross;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTax;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGroceries;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWater;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTravel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOther;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\HomeLoanWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label warnLbl;
        
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
            System.Uri resourceLocater = new System.Uri("/LoanApplication;component/homeloanwpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomeLoanWPF.xaml"
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
            this.txtGross = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\HomeLoanWPF.xaml"
            this.txtGross.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtGross_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtTax = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\HomeLoanWPF.xaml"
            this.txtTax.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtTax_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtGroceries = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtWater = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtTravel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtOther = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 38 "..\..\HomeLoanWPF.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 39 "..\..\HomeLoanWPF.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.warnLbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

