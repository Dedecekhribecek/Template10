﻿#pragma checksum "C:\git.repos\Template10\Samples\Voice and Ink to TextBox\Views\Shell.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8358446F2F6ED9DCFCF2600BBA07998D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Template10.Samples.VoiceAndInkSample.Views
{
    partial class Shell : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Template10_Controls_ModalDialog_IsModal(global::Template10.Controls.ModalDialog obj, global::System.Boolean value)
            {
                obj.IsModal = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class Shell_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IShell_Bindings
        {
            private global::Template10.Samples.VoiceAndInkSample.Views.Shell dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Template10.Controls.ModalDialog obj2;
            private global::Windows.UI.Xaml.Controls.ProgressRing obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            private Shell_obj1_BindingsTracking bindingsTracking;

            public Shell_obj1_Bindings()
            {
                this.bindingsTracking = new Shell_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Template10.Controls.ModalDialog)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IShell_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // Shell_obj1_Bindings

            public void SetDataRoot(global::Template10.Samples.VoiceAndInkSample.Views.Shell newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Template10.Samples.VoiceAndInkSample.Views.Shell obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_IsBusy(obj.IsBusy, phase);
                        this.Update_BusyText(obj.BusyText, phase);
                    }
                }
            }
            private void Update_IsBusy(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Template10_Controls_ModalDialog_IsModal(this.obj2, obj);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj4, obj);
                }
            }
            private void Update_BusyText(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                }
            }

            private class Shell_obj1_BindingsTracking
            {
                global::System.WeakReference<Shell_obj1_Bindings> WeakRefToBindingObj; 

                public Shell_obj1_BindingsTracking(Shell_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Shell_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Shell_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Template10.Samples.VoiceAndInkSample.Views.Shell obj = sender as global::Template10.Samples.VoiceAndInkSample.Views.Shell;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_IsBusy(obj.IsBusy, DATA_CHANGED);
                                    bindings.Update_BusyText(obj.BusyText, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsBusy":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_IsBusy(obj.IsBusy, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BusyText":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_BusyText(obj.BusyText, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::Template10.Samples.VoiceAndInkSample.Views.Shell obj)
                {
                    Shell_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3:
                {
                    this.MyHamburgerMenu = (global::Template10.Controls.HamburgerMenu)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Shell_obj1_Bindings bindings = new Shell_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

