/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/5/2024
 * Time: 8:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of personal_hospitalario.
	/// </summary>
	public abstract class personal_hospitalario
	{
		public Credenciales credenciales;
		public Turno turno;
	    public Single salario;
			
		public personal_hospitalario(string nombre, string apellido, string cedula, int id, Single salario)
		{
			credenciales = new Credenciales(nombre, apellido, cedula, id);
		}
		
		public void TomarTurno(DateTime fecha_inicio, DateTime fecha_fin)
		{
			turno = new Turno(credenciales.Nombre, fecha_inicio, fecha_fin);
		}
		
		public void FinalizarTurno()
		{
			turno.Finalizar();
		}
		
		public void IniciarTurno()
		{
			turno.Iniciar();
		}
	}
}
