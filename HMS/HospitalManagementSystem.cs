using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
  
    public class HospitalManagementSystem
    {
        private PatientRepository pr = new PatientRepository();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nHospital Management System");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        ViewPatients();
                        break;
                    case "3":
                        UpdatePatient();
                        break;
                    case "4":
                        DeletePatient();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("\nInvalid option! Please try again.");
                        break;
                }
            }
        }

        public void AddPatient()
        {
            Console.Write("Enter Patient Number: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Illness: ");
            string illness = Console.ReadLine();

            var patient = new Patient(id, name, age, illness); 
            pr.AddPatient(patient);
        }

        public void ViewPatients()
        {
            var patients = pr.GetPatients();
            Console.WriteLine("Patient List:");
            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
            }
        }                                          

        public void UpdatePatient()
        {
            Console.Write("Enter Patient ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter New Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter New Illness: ");
            string illness = Console.ReadLine();

            var updatedPatient = new Patient(id, name, age, illness);
            pr.UpdatePatient(id, updatedPatient);
        }

        public void DeletePatient()
        {
            Console.Write("Enter Patient ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            pr.DeletePatient(id);
        }
    }

}
