/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/5/2024
 * Time: 11:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of Enfermera.
	/// </summary>
	/// 
	
	public class Enfermera : personal_hospitalario, ISoporteAlMedico, ICirujiaRol
	{
		
		private List<Paciente> pacientes_asignados = new List<Paciente>();
		
		public Enfermera(string nombre, string apellido, string cedula, int id, Single salario) : base( nombre,  apellido,  cedula,  id, salario)
		{
			
		}
		
		public  void ParticiparEnCirujia()
		{
			Console.WriteLine("La enfermera {0} {1} esta participando en cirujia", credenciales.Nombre, credenciales.Apellido);
		}
		
		public  void AdministrarMedicamentos()
		{
			Console.WriteLine("La enfermera {0} {1} esta administrando medicamentos", credenciales.Nombre, credenciales.Apellido);
		}
		
		public  void AtenderPaciente()
		{
			Console.WriteLine("La enfermera {0} {1} esta atendiendo el paciente", credenciales.Nombre, credenciales.Apellido);
		}
		
		
		public void ListarPacientes()
		{
			foreach(Paciente paciente in pacientes_asignados)
			{
				Console.WriteLine(paciente);
			}
		}
		
		public void AgregarPaciente(Paciente paciente)
		{
			pacientes_asignados.Add(paciente);
		}
	}
}
