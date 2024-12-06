/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/6/2024
 * Time: 12:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of Paciente.
	/// </summary>
	public class Paciente
	{
		private string nombre;
		private string apellido;
		private string tratamiento;
		
		public string Nombre {get {return nombre;}}
		public string Apellido {get {return apellido;}}
		public string Tratamiento {get{return tratamiento;}}
		
		public Paciente(string  nombre, string apellido, string tratamiento)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.tratamiento = tratamiento;
		}
		
		public override string ToString()
		{
			return string.Format("[Paciente Nombre={0}, Apellido={1}, Tratamiento={2}]", nombre, apellido, tratamiento);
		}

	}
}
