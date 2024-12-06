/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/5/2024
 * Time: 11:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of Paramedico.
	/// </summary>
	public class Paramedico : personal_hospitalario, ISoporteAlMedico
	{
		private string zonaAsignada;
		public string ZonaAsignada {get {return zonaAsignada;}}
		
		public Paramedico(string nombre, string apellido, string cedula, int id, string zona, Single salario) : base ( nombre,  apellido,  cedula,  id, salario)
		{
			zonaAsignada = zona;
		}
		
		public void TrasladarPaciente()
		{
			Console.WriteLine("Trasladando paciente a centro medico");
		}
		
		public void AtenderEmergencia()
    	{
        	Console.WriteLine("El paramédico {0} está atendiendo una emergencia en la zona {1}.", credenciales.Nombre, zonaAsignada);
    	}
		
		public void AdministrarMedicamentos()
		{
			Console.WriteLine("El Paramedico {0} {1} esta administrando medicamentos", credenciales.Nombre, credenciales.Apellido);
		}
		
		public void AtenderPaciente()
		{
			Console.WriteLine("El paramedico {0} {1} esta atendiendo el paciente", credenciales.Nombre, credenciales.Apellido);
		}
	}
}
