﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_HoroscopeService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserData", Namespace="http://tempuri.org/")]
    public partial class UserData : object
    {
        
        private int IDField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string ComputerNameField;
        
        private string IpAddressField;
        
        private System.DateTime BirthDayField;
        
        private System.DateTime CurrentDateField;
        
        private int AgeField;
        
        private string SignField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ComputerName
        {
            get
            {
                return this.ComputerNameField;
            }
            set
            {
                this.ComputerNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string IpAddress
        {
            get
            {
                return this.IpAddressField;
            }
            set
            {
                this.IpAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.DateTime BirthDay
        {
            get
            {
                return this.BirthDayField;
            }
            set
            {
                this.BirthDayField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.DateTime CurrentDate
        {
            get
            {
                return this.CurrentDateField;
            }
            set
            {
                this.CurrentDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public int Age
        {
            get
            {
                return this.AgeField;
            }
            set
            {
                this.AgeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Sign
        {
            get
            {
                return this.SignField;
            }
            set
            {
                this.SignField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DB_HoroscopeService.DB_WebService1Soap")]
    public interface DB_WebService1Soap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INSERT_UserData", ReplyAction="*")]
        System.Threading.Tasks.Task<DB_HoroscopeService.INSERT_UserDataResponse> INSERT_UserDataAsync(DB_HoroscopeService.INSERT_UserDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SELECT_UserData", ReplyAction="*")]
        System.Threading.Tasks.Task<DB_HoroscopeService.SELECT_UserDataResponse> SELECT_UserDataAsync(DB_HoroscopeService.SELECT_UserDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class INSERT_UserDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="INSERT_UserData", Namespace="http://tempuri.org/", Order=0)]
        public DB_HoroscopeService.INSERT_UserDataRequestBody Body;
        
        public INSERT_UserDataRequest()
        {
        }
        
        public INSERT_UserDataRequest(DB_HoroscopeService.INSERT_UserDataRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class INSERT_UserDataRequestBody
    {
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int Age;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Sign;
        
        public INSERT_UserDataRequestBody()
        {
        }
        
        public INSERT_UserDataRequestBody(string firstName, string lastName, string computerName, string ipAddress, System.DateTime birthDay, System.DateTime currentDate, int Age, string Sign)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.computerName = computerName;
            this.ipAddress = ipAddress;
            this.birthDay = birthDay;
            this.currentDate = currentDate;
            this.Age = Age;
            this.Sign = Sign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class INSERT_UserDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="INSERT_UserDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public DB_HoroscopeService.INSERT_UserDataResponseBody Body;
        
        public INSERT_UserDataResponse()
        {
        }
        
        public INSERT_UserDataResponse(DB_HoroscopeService.INSERT_UserDataResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class INSERT_UserDataResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int INSERT_UserDataResult;
        
        public INSERT_UserDataResponseBody()
        {
        }
        
        public INSERT_UserDataResponseBody(int INSERT_UserDataResult)
        {
            this.INSERT_UserDataResult = INSERT_UserDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SELECT_UserDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SELECT_UserData", Namespace="http://tempuri.org/", Order=0)]
        public DB_HoroscopeService.SELECT_UserDataRequestBody Body;
        
        public SELECT_UserDataRequest()
        {
        }
        
        public SELECT_UserDataRequest(DB_HoroscopeService.SELECT_UserDataRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SELECT_UserDataRequestBody
    {
        
        public SELECT_UserDataRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SELECT_UserDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SELECT_UserDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public DB_HoroscopeService.SELECT_UserDataResponseBody Body;
        
        public SELECT_UserDataResponse()
        {
        }
        
        public SELECT_UserDataResponse(DB_HoroscopeService.SELECT_UserDataResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SELECT_UserDataResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DB_HoroscopeService.UserData[] SELECT_UserDataResult;
        
        public SELECT_UserDataResponseBody()
        {
        }
        
        public SELECT_UserDataResponseBody(DB_HoroscopeService.UserData[] SELECT_UserDataResult)
        {
            this.SELECT_UserDataResult = SELECT_UserDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface DB_WebService1SoapChannel : DB_HoroscopeService.DB_WebService1Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class DB_WebService1SoapClient : System.ServiceModel.ClientBase<DB_HoroscopeService.DB_WebService1Soap>, DB_HoroscopeService.DB_WebService1Soap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DB_WebService1SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(DB_WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), DB_WebService1SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DB_WebService1SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DB_WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DB_WebService1SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DB_WebService1SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DB_WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DB_HoroscopeService.INSERT_UserDataResponse> DB_HoroscopeService.DB_WebService1Soap.INSERT_UserDataAsync(DB_HoroscopeService.INSERT_UserDataRequest request)
        {
            return base.Channel.INSERT_UserDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<DB_HoroscopeService.INSERT_UserDataResponse> INSERT_UserDataAsync(string firstName, string lastName, string computerName, string ipAddress, System.DateTime birthDay, System.DateTime currentDate, int Age, string Sign)
        {
            DB_HoroscopeService.INSERT_UserDataRequest inValue = new DB_HoroscopeService.INSERT_UserDataRequest();
            inValue.Body = new DB_HoroscopeService.INSERT_UserDataRequestBody();
            inValue.Body.firstName = firstName;
            inValue.Body.lastName = lastName;
            inValue.Body.computerName = computerName;
            inValue.Body.ipAddress = ipAddress;
            inValue.Body.birthDay = birthDay;
            inValue.Body.currentDate = currentDate;
            inValue.Body.Age = Age;
            inValue.Body.Sign = Sign;
            return ((DB_HoroscopeService.DB_WebService1Soap)(this)).INSERT_UserDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DB_HoroscopeService.SELECT_UserDataResponse> DB_HoroscopeService.DB_WebService1Soap.SELECT_UserDataAsync(DB_HoroscopeService.SELECT_UserDataRequest request)
        {
            return base.Channel.SELECT_UserDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<DB_HoroscopeService.SELECT_UserDataResponse> SELECT_UserDataAsync()
        {
            DB_HoroscopeService.SELECT_UserDataRequest inValue = new DB_HoroscopeService.SELECT_UserDataRequest();
            inValue.Body = new DB_HoroscopeService.SELECT_UserDataRequestBody();
            return ((DB_HoroscopeService.DB_WebService1Soap)(this)).SELECT_UserDataAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.DB_WebService1Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.DB_WebService1Soap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.DB_WebService1Soap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:53423/DB_WebService1.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.DB_WebService1Soap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:53423/DB_WebService1.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            DB_WebService1Soap,
            
            DB_WebService1Soap12,
        }
    }
}
