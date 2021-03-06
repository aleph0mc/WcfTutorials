﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsClient2.MyMathServiceRef {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyMathServiceRef.IMathService")]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        int Add(WinFormsClient2.MyMathServiceRef.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.IAsyncResult BeginAdd(WinFormsClient2.MyMathServiceRef.MyNumbers Obj, System.AsyncCallback callback, object asyncState);
        
        int EndAdd(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        int Subtract(WinFormsClient2.MyMathServiceRef.MyNumbers Obj);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        System.IAsyncResult BeginSubtract(WinFormsClient2.MyMathServiceRef.MyNumbers Obj, System.AsyncCallback callback, object asyncState);
        
        int EndSubtract(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : WinFormsClient2.MyMathServiceRef.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubtractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SubtractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<WinFormsClient2.MyMathServiceRef.IMathService>, WinFormsClient2.MyMathServiceRef.IMathService {
        
        private BeginOperationDelegate onBeginAddDelegate;
        
        private EndOperationDelegate onEndAddDelegate;
        
        private System.Threading.SendOrPostCallback onAddCompletedDelegate;
        
        private BeginOperationDelegate onBeginSubtractDelegate;
        
        private EndOperationDelegate onEndSubtractDelegate;
        
        private System.Threading.SendOrPostCallback onSubtractCompletedDelegate;
        
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
        
        public event System.EventHandler<AddCompletedEventArgs> AddCompleted;
        
        public event System.EventHandler<SubtractCompletedEventArgs> SubtractCompleted;
        
        public int Add(WinFormsClient2.MyMathServiceRef.MyNumbers Obj) {
            return base.Channel.Add(Obj);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginAdd(WinFormsClient2.MyMathServiceRef.MyNumbers Obj, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAdd(Obj, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndAdd(System.IAsyncResult result) {
            return base.Channel.EndAdd(result);
        }
        
        private System.IAsyncResult OnBeginAdd(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WinFormsClient2.MyMathServiceRef.MyNumbers Obj = ((WinFormsClient2.MyMathServiceRef.MyNumbers)(inValues[0]));
            return this.BeginAdd(Obj, callback, asyncState);
        }
        
        private object[] OnEndAdd(System.IAsyncResult result) {
            int retVal = this.EndAdd(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddCompleted(object state) {
            if ((this.AddCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddCompleted(this, new AddCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddAsync(WinFormsClient2.MyMathServiceRef.MyNumbers Obj) {
            this.AddAsync(Obj, null);
        }
        
        public void AddAsync(WinFormsClient2.MyMathServiceRef.MyNumbers Obj, object userState) {
            if ((this.onBeginAddDelegate == null)) {
                this.onBeginAddDelegate = new BeginOperationDelegate(this.OnBeginAdd);
            }
            if ((this.onEndAddDelegate == null)) {
                this.onEndAddDelegate = new EndOperationDelegate(this.OnEndAdd);
            }
            if ((this.onAddCompletedDelegate == null)) {
                this.onAddCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddCompleted);
            }
            base.InvokeAsync(this.onBeginAddDelegate, new object[] {
                        Obj}, this.onEndAddDelegate, this.onAddCompletedDelegate, userState);
        }
        
        public int Subtract(WinFormsClient2.MyMathServiceRef.MyNumbers Obj) {
            return base.Channel.Subtract(Obj);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSubtract(WinFormsClient2.MyMathServiceRef.MyNumbers Obj, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSubtract(Obj, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndSubtract(System.IAsyncResult result) {
            return base.Channel.EndSubtract(result);
        }
        
        private System.IAsyncResult OnBeginSubtract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WinFormsClient2.MyMathServiceRef.MyNumbers Obj = ((WinFormsClient2.MyMathServiceRef.MyNumbers)(inValues[0]));
            return this.BeginSubtract(Obj, callback, asyncState);
        }
        
        private object[] OnEndSubtract(System.IAsyncResult result) {
            int retVal = this.EndSubtract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSubtractCompleted(object state) {
            if ((this.SubtractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SubtractCompleted(this, new SubtractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SubtractAsync(WinFormsClient2.MyMathServiceRef.MyNumbers Obj) {
            this.SubtractAsync(Obj, null);
        }
        
        public void SubtractAsync(WinFormsClient2.MyMathServiceRef.MyNumbers Obj, object userState) {
            if ((this.onBeginSubtractDelegate == null)) {
                this.onBeginSubtractDelegate = new BeginOperationDelegate(this.OnBeginSubtract);
            }
            if ((this.onEndSubtractDelegate == null)) {
                this.onEndSubtractDelegate = new EndOperationDelegate(this.OnEndSubtract);
            }
            if ((this.onSubtractCompletedDelegate == null)) {
                this.onSubtractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSubtractCompleted);
            }
            base.InvokeAsync(this.onBeginSubtractDelegate, new object[] {
                        Obj}, this.onEndSubtractDelegate, this.onSubtractCompletedDelegate, userState);
        }
    }
}
