﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _Compi1_P2_201612331_IDE.Servicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://chatbot.org/", ConfigurationName="Servicio.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://chatbot.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://chatbot.org/HelloWorld", ReplyAction="*")]
        _Compi1_P2_201612331_IDE.Servicio.HelloWorldResponse HelloWorld(_Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://chatbot.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.HelloWorldResponse> HelloWorldAsync(_Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://chatbot.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://chatbot.org/Bienvenido", ReplyAction="*")]
        _Compi1_P2_201612331_IDE.Servicio.BienvenidoResponse Bienvenido(_Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://chatbot.org/Bienvenido", ReplyAction="*")]
        System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.BienvenidoResponse> BienvenidoAsync(_Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento texto del espacio de nombres http://chatbot.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://chatbot.org/Probar", ReplyAction="*")]
        _Compi1_P2_201612331_IDE.Servicio.ProbarResponse Probar(_Compi1_P2_201612331_IDE.Servicio.ProbarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://chatbot.org/Probar", ReplyAction="*")]
        System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.ProbarResponse> ProbarAsync(_Compi1_P2_201612331_IDE.Servicio.ProbarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://chatbot.org/", Order=0)]
        public _Compi1_P2_201612331_IDE.Servicio.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(_Compi1_P2_201612331_IDE.Servicio.HelloWorldRequestBody Body) {
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
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://chatbot.org/", Order=0)]
        public _Compi1_P2_201612331_IDE.Servicio.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(_Compi1_P2_201612331_IDE.Servicio.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://chatbot.org/")]
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
    public partial class BienvenidoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Bienvenido", Namespace="http://chatbot.org/", Order=0)]
        public _Compi1_P2_201612331_IDE.Servicio.BienvenidoRequestBody Body;
        
        public BienvenidoRequest() {
        }
        
        public BienvenidoRequest(_Compi1_P2_201612331_IDE.Servicio.BienvenidoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://chatbot.org/")]
    public partial class BienvenidoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public BienvenidoRequestBody() {
        }
        
        public BienvenidoRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BienvenidoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BienvenidoResponse", Namespace="http://chatbot.org/", Order=0)]
        public _Compi1_P2_201612331_IDE.Servicio.BienvenidoResponseBody Body;
        
        public BienvenidoResponse() {
        }
        
        public BienvenidoResponse(_Compi1_P2_201612331_IDE.Servicio.BienvenidoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://chatbot.org/")]
    public partial class BienvenidoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BienvenidoResult;
        
        public BienvenidoResponseBody() {
        }
        
        public BienvenidoResponseBody(string BienvenidoResult) {
            this.BienvenidoResult = BienvenidoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProbarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Probar", Namespace="http://chatbot.org/", Order=0)]
        public _Compi1_P2_201612331_IDE.Servicio.ProbarRequestBody Body;
        
        public ProbarRequest() {
        }
        
        public ProbarRequest(_Compi1_P2_201612331_IDE.Servicio.ProbarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://chatbot.org/")]
    public partial class ProbarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string texto;
        
        public ProbarRequestBody() {
        }
        
        public ProbarRequestBody(string texto) {
            this.texto = texto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProbarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ProbarResponse", Namespace="http://chatbot.org/", Order=0)]
        public _Compi1_P2_201612331_IDE.Servicio.ProbarResponseBody Body;
        
        public ProbarResponse() {
        }
        
        public ProbarResponse(_Compi1_P2_201612331_IDE.Servicio.ProbarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://chatbot.org/")]
    public partial class ProbarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ProbarResult;
        
        public ProbarResponseBody() {
        }
        
        public ProbarResponseBody(string ProbarResult) {
            this.ProbarResult = ProbarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<_Compi1_P2_201612331_IDE.Servicio.WebServiceSoap>, _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _Compi1_P2_201612331_IDE.Servicio.HelloWorldResponse _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap.HelloWorld(_Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            _Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest inValue = new _Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest();
            inValue.Body = new _Compi1_P2_201612331_IDE.Servicio.HelloWorldRequestBody();
            _Compi1_P2_201612331_IDE.Servicio.HelloWorldResponse retVal = ((_Compi1_P2_201612331_IDE.Servicio.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.HelloWorldResponse> _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap.HelloWorldAsync(_Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.HelloWorldResponse> HelloWorldAsync() {
            _Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest inValue = new _Compi1_P2_201612331_IDE.Servicio.HelloWorldRequest();
            inValue.Body = new _Compi1_P2_201612331_IDE.Servicio.HelloWorldRequestBody();
            return ((_Compi1_P2_201612331_IDE.Servicio.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _Compi1_P2_201612331_IDE.Servicio.BienvenidoResponse _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap.Bienvenido(_Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest request) {
            return base.Channel.Bienvenido(request);
        }
        
        public string Bienvenido(string nombre) {
            _Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest inValue = new _Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest();
            inValue.Body = new _Compi1_P2_201612331_IDE.Servicio.BienvenidoRequestBody();
            inValue.Body.nombre = nombre;
            _Compi1_P2_201612331_IDE.Servicio.BienvenidoResponse retVal = ((_Compi1_P2_201612331_IDE.Servicio.WebServiceSoap)(this)).Bienvenido(inValue);
            return retVal.Body.BienvenidoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.BienvenidoResponse> _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap.BienvenidoAsync(_Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest request) {
            return base.Channel.BienvenidoAsync(request);
        }
        
        public System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.BienvenidoResponse> BienvenidoAsync(string nombre) {
            _Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest inValue = new _Compi1_P2_201612331_IDE.Servicio.BienvenidoRequest();
            inValue.Body = new _Compi1_P2_201612331_IDE.Servicio.BienvenidoRequestBody();
            inValue.Body.nombre = nombre;
            return ((_Compi1_P2_201612331_IDE.Servicio.WebServiceSoap)(this)).BienvenidoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _Compi1_P2_201612331_IDE.Servicio.ProbarResponse _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap.Probar(_Compi1_P2_201612331_IDE.Servicio.ProbarRequest request) {
            return base.Channel.Probar(request);
        }
        
        public string Probar(string texto) {
            _Compi1_P2_201612331_IDE.Servicio.ProbarRequest inValue = new _Compi1_P2_201612331_IDE.Servicio.ProbarRequest();
            inValue.Body = new _Compi1_P2_201612331_IDE.Servicio.ProbarRequestBody();
            inValue.Body.texto = texto;
            _Compi1_P2_201612331_IDE.Servicio.ProbarResponse retVal = ((_Compi1_P2_201612331_IDE.Servicio.WebServiceSoap)(this)).Probar(inValue);
            return retVal.Body.ProbarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.ProbarResponse> _Compi1_P2_201612331_IDE.Servicio.WebServiceSoap.ProbarAsync(_Compi1_P2_201612331_IDE.Servicio.ProbarRequest request) {
            return base.Channel.ProbarAsync(request);
        }
        
        public System.Threading.Tasks.Task<_Compi1_P2_201612331_IDE.Servicio.ProbarResponse> ProbarAsync(string texto) {
            _Compi1_P2_201612331_IDE.Servicio.ProbarRequest inValue = new _Compi1_P2_201612331_IDE.Servicio.ProbarRequest();
            inValue.Body = new _Compi1_P2_201612331_IDE.Servicio.ProbarRequestBody();
            inValue.Body.texto = texto;
            return ((_Compi1_P2_201612331_IDE.Servicio.WebServiceSoap)(this)).ProbarAsync(inValue);
        }
    }
}
