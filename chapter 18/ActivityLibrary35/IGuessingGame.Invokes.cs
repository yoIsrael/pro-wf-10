//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivityLibrary35 {
    using System;
    using System.ComponentModel;
    using System.Workflow.Activities;
    using System.Workflow.ComponentModel;
    using System.Workflow.ComponentModel.Design;
    using System.Workflow.ComponentModel.Compiler;
    
    
    [ToolboxItemAttribute(typeof(ActivityToolboxItem))]
    public partial class SendMessage : CallExternalMethodActivity {
        
        public static DependencyProperty messageProperty = DependencyProperty.Register("message", typeof(string), typeof(SendMessage));
        
        public SendMessage() {
            base.InterfaceType = typeof(ActivityLibrary35.IGuessingGame);
            base.MethodName = "SendMessage";
        }
        
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public override System.Type InterfaceType {
            get {
                return base.InterfaceType;
            }
            set {
                throw new InvalidOperationException("Cannot set InterfaceType on a derived CallExternalMethodActivity.");
            }
        }
        
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public override string MethodName {
            get {
                return base.MethodName;
            }
            set {
                throw new InvalidOperationException("Cannot set MethodName on a derived CallExternalMethodActivity.");
            }
        }
        
        [ValidationOptionAttribute(ValidationOption.Required)]
        public string message {
            get {
                return ((string)(this.GetValue(SendMessage.messageProperty)));
            }
            set {
                this.SetValue(SendMessage.messageProperty, value);
            }
        }
        
        protected override void OnMethodInvoking(System.EventArgs e) {
            this.ParameterBindings["message"].Value = this.message;
        }
    }
}
