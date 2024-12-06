/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/5/2024
 * Time: 9:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of Medico.
	/// </summary>
	public class Medico : personal_hospitalario, IMedico, ICirujiaRol, ISoporteAlMedico
	{
		private string LicenciaMedica;
		
		public Medico(string nombre, string apellido, string cedula, int id, string licencia, Single salario) : base (nombre, apellido, cedula, id, salario)
		{
			LicenciaMedica = licencia;
		}
		
		public virtual void RecetarMedicamentos()
		{
			Console.WriteLine("El medico {0} {1} esta recetando medicamentos", credenciales.Nombre, credenciales.Apellido);
		}
		
		public virtual void ParticiparEnCirujia()
		{
			Console.WriteLine("El medico {0} {1} esta participando en cirujia", credenciales.Nombre, credenciales.Apellido);
		}
		
		public virtual void AdministrarMedicamentos()
		{
			Console.WriteLine("El medico {0} {1} esta administrando medicamentos", credenciales.Nombre, credenciales.Apellido);
		}
		
		public virtual void AtenderPaciente()
		{
			Console.WriteLine("El medico {0} {1} esta atendiendo el paciente", credenciales.Nombre, credenciales.Apellido);
		}
		
		public void TransferirPacienteAEspecialista()
		{
			Console.WriteLine("El medico {0} {1} transfirio el paciente al medico especialista", credenciales.Nombre, credenciales.Apellido);
		}
		
		public void ExpedirCertificacionMedica()
		{
			Console.WriteLine("El medico {0} {1} realiza certificado | licencia medica {2}", credenciales.Nombre, credenciales.Apellido, LicenciaMedica);
		}
		
	}
}
