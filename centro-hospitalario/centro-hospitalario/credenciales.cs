/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/5/2024
 * Time: 8:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of credenciales.
	/// </summary>
	public class Credenciales
	{
		private string nombre;
		private string apellido;
		private string cedula;
		private int id;
		
		public string Nombre {get {return nombre;}}
		public string Apellido {get {return apellido;}}
		public string Cedula {get {return cedula;}}
		public int Id {get {return id;}}
		
		public Credenciales(string nombre, string apellido, string cedula, int id)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.cedula = cedula;
			this.id = id;
		}
		
		public override string ToString()
		{
			return string.Format("[credenciales Nombre={0}, Apellido={1}, Cedula={2}, Id={3}]", Nombre, Apellido, Cedula, Id);
		}

	}
}
