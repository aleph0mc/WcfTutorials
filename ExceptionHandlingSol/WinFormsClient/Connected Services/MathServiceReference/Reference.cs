﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsClient.MathServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyNumbers", Namespace="http://schemas.datacontract.org/2004/07/MathServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class MyNumbers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number2Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number1 {
            get {
                return this.Number1Field;
            }
            set {
                if ((this.Number1Field.Equals(value) != true)) {
                    this.Number1Field = value;
                    this.RaisePropertyChanged("Number1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number2 {
            get {
                return this.Number2Field;
            }
            set {
                if ((this.Number2Field.Equals(value) != true)) {
                    this.Number2Field = value;
                    this.RaisePropertyChanged("Number2");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DivisionFault", Namespace="http://schemas.datacontract.org/2004/07/MathServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class DivisionFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MethodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Method {
            get {
                return this.MethodField;
            }
            set {
                if ((object.ReferenceEquals(this.MethodField, value) != true)) {
                    this.MethodField = value;
                    this.RaisePropertyChanged("Method");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathServiceReference.IMathService")]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        int Add(WinFormsClient.MathServiceReference.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(WinFormsClient.MathServiceReference.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        int Subtract(WinFormsClient.MathServiceReference.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(WinFormsClient.MathServiceReference.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Divide", ReplyAction="http://tempuri.org/IMathService/DivideResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WinFormsClient.MathServiceReference.DivisionFault), Action="http://tempuri.org/IMathService/DivideDivisionFaultFault", Name="DivisionFault", Namespace="http://schemas.datacontract.org/2004/07/MathServiceLibrary")]
        int Divide(WinFormsClient.MathServiceReference.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Divide", ReplyAction="http://tempuri.org/IMathService/DivideResponse")]
        System.Threading.Tasks.Task<int> DivideAsync(WinFormsClient.MathServiceReference.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/DivideOneWay")]
        void DivideOneWay(WinFormsClient.MathServiceReference.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/DivideOneWay")]
        System.Threading.Tasks.Task DivideOneWayAsync(WinFormsClient.MathServiceReference.MyNumbers Obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : WinFormsClient.MathServiceReference.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<WinFormsClient.MathServiceReference.IMathService>, WinFormsClient.MathServiceReference.IMathService {
        
        public MathServiceClient() {
        }
        
        public MathServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            return base.Channel.Add(Obj);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            return base.Channel.AddAsync(Obj);
        }
        
        public int Subtract(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            return base.Channel.Subtract(Obj);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            return base.Channel.SubtractAsync(Obj);
        }
        
        public int Divide(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            return base.Channel.Divide(Obj);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            return base.Channel.DivideAsync(Obj);
        }
        
        public void DivideOneWay(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            base.Channel.DivideOneWay(Obj);
        }
        
        public System.Threading.Tasks.Task DivideOneWayAsync(WinFormsClient.MathServiceReference.MyNumbers Obj) {
            return base.Channel.DivideOneWayAsync(Obj);
        }
    }
}
