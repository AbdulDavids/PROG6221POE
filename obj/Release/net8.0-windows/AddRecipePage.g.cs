﻿#pragma checksum "..\..\..\AddRecipePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DF5FDB3A2160805AACCE84120C362D8A62782CDC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace RecipeManagerApp {
    
    
    /// <summary>
    /// AddRecipePage
    /// </summary>
    public partial class AddRecipePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\AddRecipePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipeNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AddRecipePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IngredientNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AddRecipePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AddRecipePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UnitComboBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddRecipePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaloriesTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AddRecipePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FoodGroupComboBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\AddRecipePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StepTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PROG6221ConsoleAppWPF;component/addrecipepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddRecipePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RecipeNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.IngredientNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.QuantityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UnitComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.CaloriesTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.FoodGroupComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 51 "..\..\..\AddRecipePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.StepTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 73 "..\..\..\AddRecipePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddStep_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 84 "..\..\..\AddRecipePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveRecipe_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

