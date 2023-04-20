namespace EjemplosWin
{
	public class Empleado
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Puesto { get; set; }
		public int Sueldo { get; set; }
		public int EmpresaID { get; set; }

		public string getPuesto()
		{
			return this.Puesto;
		}
	}

}
