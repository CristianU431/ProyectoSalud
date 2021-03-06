//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSalud.srConsultorio {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srConsultorio.wsConsultorioSoap")]
    public interface wsConsultorioSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Actualizar(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Eliminar(string IdConsultorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAsync(string IdConsultorio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsConsultorioSoapChannel : ClienteSalud.srConsultorio.wsConsultorioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsConsultorioSoapClient : System.ServiceModel.ClientBase<ClienteSalud.srConsultorio.wsConsultorioSoap>, ClienteSalud.srConsultorio.wsConsultorioSoap {
        
        public wsConsultorioSoapClient() {
        }
        
        public wsConsultorioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsConsultorioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsConsultorioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsConsultorioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad) {
            return base.Channel.Agregar(IdConsultorio, NumConsultorio, CodMedico, IdEspecialidad);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad) {
            return base.Channel.AgregarAsync(IdConsultorio, NumConsultorio, CodMedico, IdEspecialidad);
        }
        
        public string[] Actualizar(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad) {
            return base.Channel.Actualizar(IdConsultorio, NumConsultorio, CodMedico, IdEspecialidad);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAsync(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad) {
            return base.Channel.ActualizarAsync(IdConsultorio, NumConsultorio, CodMedico, IdEspecialidad);
        }
        
        public string[] Eliminar(string IdConsultorio) {
            return base.Channel.Eliminar(IdConsultorio);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAsync(string IdConsultorio) {
            return base.Channel.EliminarAsync(IdConsultorio);
        }
        
        public System.Data.DataSet Buscar(string texto, string criterio) {
            return base.Channel.Buscar(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio) {
            return base.Channel.BuscarAsync(texto, criterio);
        }
    }
}
