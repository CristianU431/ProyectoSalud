﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSalud.srReceta {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srReceta.wsRecetaSoap")]
    public interface wsRecetaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Actualizar(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Eliminar(string IdReceta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAsync(string IdReceta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsRecetaSoapChannel : ClienteSalud.srReceta.wsRecetaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsRecetaSoapClient : System.ServiceModel.ClientBase<ClienteSalud.srReceta.wsRecetaSoap>, ClienteSalud.srReceta.wsRecetaSoap {
        
        public wsRecetaSoapClient() {
        }
        
        public wsRecetaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsRecetaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsRecetaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsRecetaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio) {
            return base.Channel.Agregar(IdReceta, Dni, Enfermedad, IdMedicamentos, Descripcion, FechaInicio, FechaLimite, TipoReceta, CodMedico, IdConsultorio);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio) {
            return base.Channel.AgregarAsync(IdReceta, Dni, Enfermedad, IdMedicamentos, Descripcion, FechaInicio, FechaLimite, TipoReceta, CodMedico, IdConsultorio);
        }
        
        public string[] Actualizar(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio) {
            return base.Channel.Actualizar(IdReceta, Dni, Enfermedad, IdMedicamentos, Descripcion, FechaInicio, FechaLimite, TipoReceta, CodMedico, IdConsultorio);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio) {
            return base.Channel.ActualizarAsync(IdReceta, Dni, Enfermedad, IdMedicamentos, Descripcion, FechaInicio, FechaLimite, TipoReceta, CodMedico, IdConsultorio);
        }
        
        public string[] Eliminar(string IdReceta) {
            return base.Channel.Eliminar(IdReceta);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAsync(string IdReceta) {
            return base.Channel.EliminarAsync(IdReceta);
        }
        
        public System.Data.DataSet Buscar(string texto, string criterio) {
            return base.Channel.Buscar(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio) {
            return base.Channel.BuscarAsync(texto, criterio);
        }
    }
}