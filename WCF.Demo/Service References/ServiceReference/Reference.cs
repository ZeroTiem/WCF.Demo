﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Demo.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Member", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Member : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreateAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> FlagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifyAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ModifyDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public string CreateAccount {
            get {
                return this.CreateAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.CreateAccountField, value) != true)) {
                    this.CreateAccountField = value;
                    this.RaisePropertyChanged("CreateAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Flag {
            get {
                return this.FlagField;
            }
            set {
                if ((this.FlagField.Equals(value) != true)) {
                    this.FlagField = value;
                    this.RaisePropertyChanged("Flag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModifyAccount {
            get {
                return this.ModifyAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifyAccountField, value) != true)) {
                    this.ModifyAccountField = value;
                    this.RaisePropertyChanged("ModifyAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate {
            get {
                return this.ModifyDateField;
            }
            set {
                if ((this.ModifyDateField.Equals(value) != true)) {
                    this.ModifyDateField = value;
                    this.RaisePropertyChanged("ModifyDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int No {
            get {
                return this.NoField;
            }
            set {
                if ((this.NoField.Equals(value) != true)) {
                    this.NoField = value;
                    this.RaisePropertyChanged("No");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Member_Get_Result", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Member_Get_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreateAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> FlagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifyAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ModifyDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public string CreateAccount {
            get {
                return this.CreateAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.CreateAccountField, value) != true)) {
                    this.CreateAccountField = value;
                    this.RaisePropertyChanged("CreateAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Flag {
            get {
                return this.FlagField;
            }
            set {
                if ((this.FlagField.Equals(value) != true)) {
                    this.FlagField = value;
                    this.RaisePropertyChanged("Flag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModifyAccount {
            get {
                return this.ModifyAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifyAccountField, value) != true)) {
                    this.ModifyAccountField = value;
                    this.RaisePropertyChanged("ModifyAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate {
            get {
                return this.ModifyDateField;
            }
            set {
                if ((this.ModifyDateField.Equals(value) != true)) {
                    this.ModifyDateField = value;
                    this.RaisePropertyChanged("ModifyDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int No {
            get {
                return this.NoField;
            }
            set {
                if ((this.NoField.Equals(value) != true)) {
                    this.NoField = value;
                    this.RaisePropertyChanged("No");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Member_GetByNo_Result", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Member_GetByNo_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreateAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> FlagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifyAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ModifyDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public string CreateAccount {
            get {
                return this.CreateAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.CreateAccountField, value) != true)) {
                    this.CreateAccountField = value;
                    this.RaisePropertyChanged("CreateAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Flag {
            get {
                return this.FlagField;
            }
            set {
                if ((this.FlagField.Equals(value) != true)) {
                    this.FlagField = value;
                    this.RaisePropertyChanged("Flag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModifyAccount {
            get {
                return this.ModifyAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifyAccountField, value) != true)) {
                    this.ModifyAccountField = value;
                    this.RaisePropertyChanged("ModifyAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifyDate {
            get {
                return this.ModifyDateField;
            }
            set {
                if ((this.ModifyDateField.Equals(value) != true)) {
                    this.ModifyDateField = value;
                    this.RaisePropertyChanged("ModifyDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int No {
            get {
                return this.NoField;
            }
            set {
                if ((this.NoField.Equals(value) != true)) {
                    this.NoField = value;
                    this.RaisePropertyChanged("No");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        WCF.Demo.ServiceReference.CompositeType GetDataUsingDataContract(WCF.Demo.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WCF.Demo.ServiceReference.CompositeType> GetDataUsingDataContractAsync(WCF.Demo.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        void Add(WCF.Demo.ServiceReference.Member member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(WCF.Demo.ServiceReference.Member member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        void Update(WCF.Demo.ServiceReference.Member member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(WCF.Demo.ServiceReference.Member member);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Get", ReplyAction="http://tempuri.org/IService/GetResponse")]
        WCF.Demo.ServiceReference.Member_Get_Result[] Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Get", ReplyAction="http://tempuri.org/IService/GetResponse")]
        System.Threading.Tasks.Task<WCF.Demo.ServiceReference.Member_Get_Result[]> GetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByNo", ReplyAction="http://tempuri.org/IService/GetByNoResponse")]
        WCF.Demo.ServiceReference.Member_GetByNo_Result GetByNo(int No);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByNo", ReplyAction="http://tempuri.org/IService/GetByNoResponse")]
        System.Threading.Tasks.Task<WCF.Demo.ServiceReference.Member_GetByNo_Result> GetByNoAsync(int No);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        void Delete(int No);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int No);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WCF.Demo.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WCF.Demo.ServiceReference.IService>, WCF.Demo.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCF.Demo.ServiceReference.CompositeType GetDataUsingDataContract(WCF.Demo.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WCF.Demo.ServiceReference.CompositeType> GetDataUsingDataContractAsync(WCF.Demo.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void Add(WCF.Demo.ServiceReference.Member member) {
            base.Channel.Add(member);
        }
        
        public System.Threading.Tasks.Task AddAsync(WCF.Demo.ServiceReference.Member member) {
            return base.Channel.AddAsync(member);
        }
        
        public void Update(WCF.Demo.ServiceReference.Member member) {
            base.Channel.Update(member);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(WCF.Demo.ServiceReference.Member member) {
            return base.Channel.UpdateAsync(member);
        }
        
        public WCF.Demo.ServiceReference.Member_Get_Result[] Get() {
            return base.Channel.Get();
        }
        
        public System.Threading.Tasks.Task<WCF.Demo.ServiceReference.Member_Get_Result[]> GetAsync() {
            return base.Channel.GetAsync();
        }
        
        public WCF.Demo.ServiceReference.Member_GetByNo_Result GetByNo(int No) {
            return base.Channel.GetByNo(No);
        }
        
        public System.Threading.Tasks.Task<WCF.Demo.ServiceReference.Member_GetByNo_Result> GetByNoAsync(int No) {
            return base.Channel.GetByNoAsync(No);
        }
        
        public void Delete(int No) {
            base.Channel.Delete(No);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int No) {
            return base.Channel.DeleteAsync(No);
        }
    }
}
