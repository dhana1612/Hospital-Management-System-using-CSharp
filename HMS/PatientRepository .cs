using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
   
    public class PatientRepository
    {
        private List<Patient> patients = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine("\nPatient added successfully!");
        }

        public IEnumerable<Patient> GetPatients()
        {
            return patients;
        }

        public Patient GetPatientById(int id)
        {
            foreach (var patient in patients)
            {
                if (patient.Id == id)
                {
                    return patient; 
                }
            }
            return null;
        }

        public void UpdatePatient(int id, Patient updatedPatient)
        {
            var patient = GetPatientById(id);
            if (patient != null)
            {
                patient.Name = updatedPatient.Name;
                patient.Age = updatedPatient.Age;
                patient.Illness = updatedPatient.Illness;
                Console.WriteLine("\nPatient updated successfully!");
            }
            else
            {
                Console.WriteLine("\nPatient not found!");
            }
        }                   

        public void DeletePatient(int id)
        {
            var patient = GetPatientById(id);
            if (patient != null)
            {
                patients.Remove(patient);
                Console.WriteLine("\nPatient deleted successfully!");
            }
            else
            {
                Console.WriteLine("\nPatient not found!");
            }
        }
    }

}
