﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP_Console_HoroscopeClient3.HoroscopeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HoroscopeService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponse HelloWorld(TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponse> HelloWorldAsync(TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name firstName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Horoscope", ReplyAction="*")]
        TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponse Horoscope(TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Horoscope", ReplyAction="*")]
        System.Threading.Tasks.Task<TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponse> HoroscopeAsync(TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HoroscopeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Horoscope", Namespace="http://tempuri.org/", Order=0)]
        public TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequestBody Body;
        
        public HoroscopeRequest() {
        }
        
        public HoroscopeRequest(TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HoroscopeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string firstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string computerName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ipAddress;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.DateTime birthDay;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public System.DateTime currentDate;
        
        public HoroscopeRequestBody() {
        }
        
        public HoroscopeRequestBody(string firstName, string lastName, string computerName, string ipAddress, System.DateTime birthDay, System.DateTime currentDate) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.computerName = computerName;
            this.ipAddress = ipAddress;
            this.birthDay = birthDay;
            this.currentDate = currentDate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HoroscopeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HoroscopeResponse", Namespace="http://tempuri.org/", Order=0)]
        public TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponseBody Body;
        
        public HoroscopeResponse() {
        }
        
        public HoroscopeResponse(TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HoroscopeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TP_Console_HoroscopeClient3.HoroscopeService.ArrayOfString HoroscopeResult;
        
        public HoroscopeResponseBody() {
        }
        
        public HoroscopeResponseBody(TP_Console_HoroscopeClient3.HoroscopeService.ArrayOfString HoroscopeResult) {
            this.HoroscopeResult = HoroscopeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap>, TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponse TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap.HelloWorld(TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest inValue = new TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest();
            inValue.Body = new TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequestBody();
            TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponse retVal = ((TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponse> TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap.HelloWorldAsync(TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldResponse> HelloWorldAsync() {
            TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest inValue = new TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequest();
            inValue.Body = new TP_Console_HoroscopeClient3.HoroscopeService.HelloWorldRequestBody();
            return ((TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponse TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap.Horoscope(TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest request) {
            return base.Channel.Horoscope(request);
        }
        
        public TP_Console_HoroscopeClient3.HoroscopeService.ArrayOfString Horoscope(string firstName, string lastName, string computerName, string ipAddress, System.DateTime birthDay, System.DateTime currentDate) {
            TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest inValue = new TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest();
            inValue.Body = new TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequestBody();
            inValue.Body.firstName = firstName;
            inValue.Body.lastName = lastName;
            inValue.Body.computerName = computerName;
            inValue.Body.ipAddress = ipAddress;
            inValue.Body.birthDay = birthDay;
            inValue.Body.currentDate = currentDate;
            TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponse retVal = ((TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap)(this)).Horoscope(inValue);
            return retVal.Body.HoroscopeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponse> TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap.HoroscopeAsync(TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest request) {
            return base.Channel.HoroscopeAsync(request);
        }
        
        public System.Threading.Tasks.Task<TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeResponse> HoroscopeAsync(string firstName, string lastName, string computerName, string ipAddress, System.DateTime birthDay, System.DateTime currentDate) {
            TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest inValue = new TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequest();
            inValue.Body = new TP_Console_HoroscopeClient3.HoroscopeService.HoroscopeRequestBody();
            inValue.Body.firstName = firstName;
            inValue.Body.lastName = lastName;
            inValue.Body.computerName = computerName;
            inValue.Body.ipAddress = ipAddress;
            inValue.Body.birthDay = birthDay;
            inValue.Body.currentDate = currentDate;
            return ((TP_Console_HoroscopeClient3.HoroscopeService.WebService1Soap)(this)).HoroscopeAsync(inValue);
        }
    }
}