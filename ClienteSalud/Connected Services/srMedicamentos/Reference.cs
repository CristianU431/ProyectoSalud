﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSalud.srMedicamentos {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srMedicamentos.wsMedicamentosSoap")]
    public interface wsMedicamentosSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Actualizar(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Eliminar(string IdMedicamentos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAsync(string IdMedicamentos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsMedicamentosSoapChannel : ClienteSalud.srMedicamentos.wsMedicamentosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsMedicamentosSoapClient : System.ServiceModel.ClientBase<ClienteSalud.srMedicamentos.wsMedicamentosSoap>, ClienteSalud.srMedicamentos.wsMedicamentosSoap {
        
        public wsMedicamentosSoapClient() {
        }
        
        public wsMedicamentosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsMedicamentosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsMedicamentosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsMedicamentosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad) {
            return base.Channel.Agregar(IdMedicamentos, NombreMedicamentos, TipoMedicamento, Detalle, cantidad);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad) {
            return base.Channel.AgregarAsync(IdMedicamentos, NombreMedicamentos, TipoMedicamento, Detalle, cantidad);
        }
        
        public string[] Actualizar(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad) {
            return base.Channel.Actualizar(IdMedicamentos, NombreMedicamentos, TipoMedicamento, Detalle, cantidad);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad) {
            return base.Channel.ActualizarAsync(IdMedicamentos, NombreMedicamentos, TipoMedicamento, Detalle, cantidad);
        }
        
        public string[] Eliminar(string IdMedicamentos) {
            return base.Channel.Eliminar(IdMedicamentos);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAsync(string IdMedicamentos) {
            return base.Channel.EliminarAsync(IdMedicamentos);
        }
        
        public System.Data.DataSet Buscar(string texto, string criterio) {
            return base.Channel.Buscar(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio) {
            return base.Channel.BuscarAsync(texto, criterio);
        }
    }
}
