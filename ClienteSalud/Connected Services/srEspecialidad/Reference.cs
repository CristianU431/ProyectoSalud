﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSalud.srEspecialidad {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srEspecialidad.wsEspecialidadSoap")]
    public interface wsEspecialidadSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string IdEspecialidad, string NombreEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string IdEspecialidad, string NombreEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Actualizar(string IdEspecialidad, string NombreEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdEspecialidad, string NombreEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Eliminar(string IdEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAsync(string IdEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsEspecialidadSoapChannel : ClienteSalud.srEspecialidad.wsEspecialidadSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsEspecialidadSoapClient : System.ServiceModel.ClientBase<ClienteSalud.srEspecialidad.wsEspecialidadSoap>, ClienteSalud.srEspecialidad.wsEspecialidadSoap {
        
        public wsEspecialidadSoapClient() {
        }
        
        public wsEspecialidadSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsEspecialidadSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsEspecialidadSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsEspecialidadSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(string IdEspecialidad, string NombreEspecialidad) {
            return base.Channel.Agregar(IdEspecialidad, NombreEspecialidad);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string IdEspecialidad, string NombreEspecialidad) {
            return base.Channel.AgregarAsync(IdEspecialidad, NombreEspecialidad);
        }
        
        public string[] Actualizar(string IdEspecialidad, string NombreEspecialidad) {
            return base.Channel.Actualizar(IdEspecialidad, NombreEspecialidad);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdEspecialidad, string NombreEspecialidad) {
            return base.Channel.ActualizarAsync(IdEspecialidad, NombreEspecialidad);
        }
        
        public string[] Eliminar(string IdEspecialidad) {
            return base.Channel.Eliminar(IdEspecialidad);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAsync(string IdEspecialidad) {
            return base.Channel.EliminarAsync(IdEspecialidad);
        }
        
        public System.Data.DataSet Buscar(string texto, string criterio) {
            return base.Channel.Buscar(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio) {
            return base.Channel.BuscarAsync(texto, criterio);
        }
    }
}