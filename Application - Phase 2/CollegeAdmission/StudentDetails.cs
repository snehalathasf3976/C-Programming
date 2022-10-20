using System;
namespace CollegeAdmission
{
    public enum Gender{Default , Male , Female , Transgender}
    public class StudentDetails
    {
        static int s_studentId = 1000 ;
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender StudentGender { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }
    
        public StudentDetails(string name , string fatherName , DateTime dob , Gender gender , int physicsMark , int chemistryMark , int mathsMark)
        {
            s_studentId++;
            StudentId = "SF" + s_studentId;
            StudentName = name;
            FatherName = fatherName ; 
            DOB = dob ;
            StudentGender = gender ;
            PhysicsMark = physicsMark ;
            ChemistryMark = chemistryMark ;
            MathsMark = mathsMark ;
        }

        public StudentDetails(string data)
        {
            string[] values = data.Split(',');
            s_studentId = int.Parse(values[0].Remove(0,2));
            StudentId = values[0];
            StudentName = values[1];
            FatherName = values [2];
            DOB = DateTime.ParseExact(values[3] ,"dd/MM/yyyy",null);
            StudentGender = Enum.Parse<Gender>(values[4]);
            PhysicsMark = int.Parse(values[5]);
            ChemistryMark =int.Parse(values[6]);
            MathsMark = int.Parse(values[7]);
        }


        public  bool CheckEligibility (double cutOff)
        {
            double average = (double) (PhysicsMark + ChemistryMark + MathsMark)/3.0 ;
            if(average >= cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}