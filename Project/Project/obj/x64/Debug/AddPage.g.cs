﻿#pragma checksum "C:\Users\Helen\Desktop\YEAR 3\Mobile Apps\Project\other\Project\Project\AddPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "205F091C932577461DF436E2B39839DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    partial class AddPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Content = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.FileText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.DocumentName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.Save = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\AddPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Save).Click += this.Save_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.SelectTextFile = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\AddPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SelectTextFile).Tapped += this.SelectTextFile_Tapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

