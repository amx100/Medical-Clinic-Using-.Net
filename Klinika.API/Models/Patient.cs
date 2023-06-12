﻿using System.ComponentModel.DataAnnotations;

namespace Klinika.API.Models
{
	public class Patient
	{
		[Key]
		public int patientID { get; set; }
		public string name { get; set; } = string.Empty;
		public string lastname { get; set; } = string.Empty;
		public DateTime date_of_birth { get; set; }
		public Department Department { get; set; }
		public int departmentID { get; set; }
		public List<Appointment> Appointments { get; set; }
		public List<Diagnose> Diagnoses { get; set; }
	}
}
