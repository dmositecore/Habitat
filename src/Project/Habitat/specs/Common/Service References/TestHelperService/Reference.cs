﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Foundation.Testing.Specflow.TestHelperService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sitecore.net/AutoTestsHelperService.asmx", ConfigurationName="TestHelperService.AutoTestsHelperServiceSoap")]
    public interface AutoTestsHelperServiceSoap {
        
        // CODEGEN: Generating message contract since element name userName from namespace http://sitecore.net/AutoTestsHelperService.asmx is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/CreateUser", ReplyAction="*")]
        Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponse CreateUser(Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/CreateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponse> CreateUserAsync(Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://sitecore.net/AutoTestsHelperService.asmx is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/DeleteUser", ReplyAction="*")]
        Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponse DeleteUser(Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/DeleteUser", ReplyAction="*")]
        System.Threading.Tasks.Task<Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponse> DeleteUserAsync(Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/IndexDatabases", ReplyAction="*")]
        void IndexDatabases();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/IndexDatabases", ReplyAction="*")]
        System.Threading.Tasks.Task IndexDatabasesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/IndexMasterDatabases", ReplyAction="*")]
        void IndexMasterDatabases();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sitecore.net/AutoTestsHelperService.asmx/IndexMasterDatabases", ReplyAction="*")]
        System.Threading.Tasks.Task IndexMasterDatabasesAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateUser", Namespace="http://sitecore.net/AutoTestsHelperService.asmx", Order=0)]
        public Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequestBody Body;
        
        public CreateUserRequest() {
        }
        
        public CreateUserRequest(Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/AutoTestsHelperService.asmx")]
    public partial class CreateUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public CreateUserRequestBody() {
        }
        
        public CreateUserRequestBody(string userName, string password) {
            this.userName = userName;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateUserResponse", Namespace="http://sitecore.net/AutoTestsHelperService.asmx", Order=0)]
        public Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponseBody Body;
        
        public CreateUserResponse() {
        }
        
        public CreateUserResponse(Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/AutoTestsHelperService.asmx")]
    public partial class CreateUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CreateUserResult;
        
        public CreateUserResponseBody() {
        }
        
        public CreateUserResponseBody(bool CreateUserResult) {
            this.CreateUserResult = CreateUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteUser", Namespace="http://sitecore.net/AutoTestsHelperService.asmx", Order=0)]
        public Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequestBody Body;
        
        public DeleteUserRequest() {
        }
        
        public DeleteUserRequest(Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/AutoTestsHelperService.asmx")]
    public partial class DeleteUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        public DeleteUserRequestBody() {
        }
        
        public DeleteUserRequestBody(string userName) {
            this.userName = userName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteUserResponse", Namespace="http://sitecore.net/AutoTestsHelperService.asmx", Order=0)]
        public Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponseBody Body;
        
        public DeleteUserResponse() {
        }
        
        public DeleteUserResponse(Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sitecore.net/AutoTestsHelperService.asmx")]
    public partial class DeleteUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool DeleteUserResult;
        
        public DeleteUserResponseBody() {
        }
        
        public DeleteUserResponseBody(bool DeleteUserResult) {
            this.DeleteUserResult = DeleteUserResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AutoTestsHelperServiceSoapChannel : Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AutoTestsHelperServiceSoapClient : System.ServiceModel.ClientBase<Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap>, Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap {
        
        public AutoTestsHelperServiceSoapClient() {
        }
        
        public AutoTestsHelperServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AutoTestsHelperServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutoTestsHelperServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutoTestsHelperServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponse Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap.CreateUser(Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest request) {
            return base.Channel.CreateUser(request);
        }
        
        public bool CreateUser(string userName, string password) {
            Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest inValue = new Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest();
            inValue.Body = new Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponse retVal = ((Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap)(this)).CreateUser(inValue);
            return retVal.Body.CreateUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponse> Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap.CreateUserAsync(Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest request) {
            return base.Channel.CreateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserResponse> CreateUserAsync(string userName, string password) {
            Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest inValue = new Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequest();
            inValue.Body = new Sitecore.Foundation.Testing.Specflow.TestHelperService.CreateUserRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            return ((Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap)(this)).CreateUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponse Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap.DeleteUser(Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest request) {
            return base.Channel.DeleteUser(request);
        }
        
        public bool DeleteUser(string userName) {
            Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest inValue = new Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest();
            inValue.Body = new Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequestBody();
            inValue.Body.userName = userName;
            Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponse retVal = ((Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap)(this)).DeleteUser(inValue);
            return retVal.Body.DeleteUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponse> Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap.DeleteUserAsync(Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest request) {
            return base.Channel.DeleteUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserResponse> DeleteUserAsync(string userName) {
            Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest inValue = new Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequest();
            inValue.Body = new Sitecore.Foundation.Testing.Specflow.TestHelperService.DeleteUserRequestBody();
            inValue.Body.userName = userName;
            return ((Sitecore.Foundation.Testing.Specflow.TestHelperService.AutoTestsHelperServiceSoap)(this)).DeleteUserAsync(inValue);
        }
        
        public void IndexDatabases() {
            base.Channel.IndexDatabases();
        }
        
        public System.Threading.Tasks.Task IndexDatabasesAsync() {
            return base.Channel.IndexDatabasesAsync();
        }
        
        public void IndexMasterDatabases() {
            base.Channel.IndexMasterDatabases();
        }
        
        public System.Threading.Tasks.Task IndexMasterDatabasesAsync() {
            return base.Channel.IndexMasterDatabasesAsync();
        }
    }
}
