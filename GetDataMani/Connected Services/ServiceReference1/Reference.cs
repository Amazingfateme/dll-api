﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetDataMani.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="ServiceReference1.IGetData")]
    public interface IGetData {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetAddressFileSRV", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetAddressFileSRVResponse")]
        void GetAddressFileSRV(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetAddressFileSRV", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetAddressFileSRVResponse")]
        System.Threading.Tasks.Task GetAddressFileSRVAsync(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountNum", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountNumResponse")]
        void GetAccountNum(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountNum", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountNumResponse")]
        System.Threading.Tasks.Task GetAccountNumAsync(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetPassword", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetPasswordResponse")]
        void GetPassword(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetPassword", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetPasswordResponse")]
        System.Threading.Tasks.Task GetPasswordAsync(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetStatuseRUN", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetStatuseRUNResponse")]
        void GetStatuseRUN(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetStatuseRUN", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetStatuseRUNResponse")]
        System.Threading.Tasks.Task GetStatuseRUNAsync(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountType", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountTypeResponse")]
        void GetAccountType(string Value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountType", ReplyAction="http://Microsoft.ServiceModel.Samples/IGetData/GetAccountTypeResponse")]
        System.Threading.Tasks.Task GetAccountTypeAsync(string Value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetDataChannel : GetDataMani.ServiceReference1.IGetData, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataClient : System.ServiceModel.ClientBase<GetDataMani.ServiceReference1.IGetData>, GetDataMani.ServiceReference1.IGetData {
        
        public GetDataClient() {
        }
        
        public GetDataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetDataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetDataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetDataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GetAddressFileSRV(string Value) {
            base.Channel.GetAddressFileSRV(Value);
        }
        
        public System.Threading.Tasks.Task GetAddressFileSRVAsync(string Value) {
            return base.Channel.GetAddressFileSRVAsync(Value);
        }
        
        public void GetAccountNum(string Value) {
            base.Channel.GetAccountNum(Value);
        }
        
        public System.Threading.Tasks.Task GetAccountNumAsync(string Value) {
            return base.Channel.GetAccountNumAsync(Value);
        }
        
        public void GetPassword(string Value) {
            base.Channel.GetPassword(Value);
        }
        
        public System.Threading.Tasks.Task GetPasswordAsync(string Value) {
            return base.Channel.GetPasswordAsync(Value);
        }
        
        public void GetStatuseRUN(string Value) {
            base.Channel.GetStatuseRUN(Value);
        }
        
        public System.Threading.Tasks.Task GetStatuseRUNAsync(string Value) {
            return base.Channel.GetStatuseRUNAsync(Value);
        }
        
        public void GetAccountType(string Value) {
            base.Channel.GetAccountType(Value);
        }
        
        public System.Threading.Tasks.Task GetAccountTypeAsync(string Value) {
            return base.Channel.GetAccountTypeAsync(Value);
        }
    }
}
