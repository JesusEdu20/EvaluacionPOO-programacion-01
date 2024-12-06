/*
 * Created by SharpDevelop.
 * User: ddd
 * Date: 12/5/2024
 * Time: 8:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace centro_hospitalario
{
	/// <summary>
	/// Description of Turno.
	/// </summary>
	public class Turno
	{	
		
		private int id;
		private string profesional_nombre;
		private DateTime fecha_inicio;
		private DateTime fecha_fin;
		private double duracion; // Expresado en Minutos
		private Boolean finalizado;
		
		public string Profesional_nombre {get {return profesional_nombre;}}
		public double Duracion {get {return duracion;}}
		public DateTime Fecha_inicio {get {return fecha_inicio;}}
		public DateTime Fecha_fin {get {return fecha_fin;}}
		public Boolean Finalizado {get {return finalizado;}}
		public int Id {get {return id;}}
		
		public Turno(string nombre, DateTime fecha_inicio, DateTime fecha_fin)
		{
			this.profesional_nombre = nombre;
			this.fecha_inicio = fecha_inicio;
			this.fecha_fin = fecha_fin;
			TimeSpan diferencia = fecha_fin - fecha_inicio;
			this.duracion = diferencia.TotalMinutes;
			// set id
			Random random = new Random();
			id = random.Next(1, 10000);
		}
		
		public void Iniciar()
		{
			if(finalizado)
			{
				Console.WriteLine("Error: Turno finalizado. El Turno no se encuentra disponible");
				return;
			}
			
			fecha_inicio = DateTime.Now;
		}
		
		public void Finalizar()
		{
			if(finalizado != true)
			{
				TimeSpan diferencia = DateTime.Now - fecha_inicio;
				if(diferencia.TotalMinutes == duracion)
				{
					finalizado = true;
					return;
				}
				Console.WriteLine("Aun no ha completado las horas del turno.");
				return;
			}
			
			Console.WriteLine("Error: El turno ya se encuentra finalizado.");
		}
	}
}
