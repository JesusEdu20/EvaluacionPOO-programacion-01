/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/5/2024
 * Time: 10:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of Especialista.
	/// </summary>
	public class Especialista : Medico
	{
		private string especialidad;
		public string Especialidad {get {return especialidad;}}
		
		
		public Especialista(string nombre, string apellido, string cedula, int id, string especialidad, string licencia, Single salario) : base(nombre, apellido, cedula, id, licencia, salario)
		{
			this.especialidad = especialidad;
		}
		
		public void BrindarConsultaEspecializada()
		{
			Console.WriteLine("El Medico especialista en {0} {1} {2} esta realizando la consulta", Especialidad, credenciales.Nombre, credenciales.Apellido);
		}
		
		///
		public override void ParticiparEnCirujia()
        {
            Console.WriteLine("{0} está liderando una cirugía como medico especialista en {1}.", credenciales.Nombre);
        }
		
		public override void RecetarMedicamentos()
		{
			Console.WriteLine("El Medico especialista {0} {1} esta recetando medicamentos", credenciales.Nombre, credenciales.Apellido);
		}
		
		///
		
		public override void AtenderPaciente()
		{
			Console.WriteLine("El medico especialista {0} {1} no realiza consultas de atencion primaria", credenciales.Nombre, credenciales.Apellido);
		}
		
		public override void AdministrarMedicamentos()
		{
			Console.WriteLine("El medico especialista {0} {1} no administa medicamentos ", credenciales.Nombre, credenciales.Apellido);
		}
	}
}
