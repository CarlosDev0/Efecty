using Dominio.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using System.Data.SqlClient;
using Dominio.Interfaces;
using System;
using Dominio.Dto;

namespace AccesoDatos.Repository
{
    public class BDRepository: IBDRepository
    {
        private const string Cadena = "Data Source=DECOL00065\\SQLEXPRESS;Initial Catalog=Prueba1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public IEnumerable<Cliente> ConsultarClientes()
        {
            
            var consulta = @"ConsultarClientes";

            using (IDbConnection db = new SqlConnection(Cadena))
            {

                var clientes = (List<Cliente>)db.Query<Cliente>(consulta, commandType: CommandType.StoredProcedure);
            
                return clientes;
            }
        }
        public DtoRespuesta GuardarClientes(Cliente cliente)
        {
            
                var consulta = @"GuardarCliente";
                var parameters = new DynamicParameters();
                parameters.Add("@NombreApellidos", cliente.nombreApellidos);
                parameters.Add("@TipoDocumento", cliente.tipoDocumento);
                parameters.Add("@FechaNacimiento", cliente.fechaNacimiento);
                parameters.Add("@ValorGanar", cliente.valorGanar);
                parameters.Add("@EstadoCivil", cliente.estadoCivil);

            using (IDbConnection db = new SqlConnection(Cadena))
            {

                
                try
                {
                    var ListaClientes = (List<DtoRespuesta>)db.Query<DtoRespuesta>(consulta, parameters, commandType: CommandType.StoredProcedure);
                    return ListaClientes.FirstOrDefault();
                }
                catch (Exception ex) {
                    return null;
                }
                
            }
        }
    }
}
