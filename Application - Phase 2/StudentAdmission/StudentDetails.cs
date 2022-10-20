using System;
/// <summary>
/// Used to Process the Student Admission Process In Colleges
/// </summary>
namespace StudentAdmission
{
    public enum Gender { Default , Male , Female , Transgender}
    internal class StudentDetails
    {
        
        private static int s_registrationId = 3000;
        /// <summary>
        /// This Property is to Auto increement Registration Id to the Object  And uniquely identify a object 
        /// </summary>
        /// <value>0-100</value>
        public string RegistrationId { get; set; }
        /// <summary>
        /// Assign the Name of the student to StudentName Property
        /// </summary>
        /// <value></value>
        public string StudentName { get; set; }
        /// <summary>
        /// Assign the Fathername of the Student to FatherName Property
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Select the gender using this Property
        /// </summary>
        /// <value></value>
        public Gender StudentGender { get; set; }
        /// <summary>
        /// Assign Date of Birth of the Student to this Property
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Assign the MailId of the Student to MailId Property
        /// </summary>
        /// <value></value>
        public string MailId{ get; set; }
        /// <summary>
        /// Assign the PhysicsMark of the Student to PhysicsMark Property
        /// </summary>
        /// <value></value>
        public int PhysicsMark { get; set; }
        /// <summary>
        /// Assign the ChemitryMark of the Student to ChemistryMark Property
        /// </summary>
        /// <value></value>
        public int ChemistryMark { get; set; }
        /// <summary>
        /// Assign the MathsMark of the Student to MathsMArk Property
        /// </summary>
        /// <value></value>
        public int MathsMark { get; set; }

        public StudentDetails()
        {
            StudentName = "Your Name";
            FatherName = "Your Father Name";
            MailId = "Your Mail Id";
        }
        /// <summary>
        /// Assigning Values Passed via Parameter to the class Property
        /// </summary>
        /// <param name="name"></param>Parameter name used to initialize StudentName Property 
        /// <param name="fatherName"></param>Parameter fathername used to initialize FatherName Property 
        /// <param name="gender"></param>Parameter gender used to initialize Gender Property 
        /// <param name="dateOfBirth"></param>Parameter dateOfBirth used to initialize DOB Property 
        /// <param name="mailId"></param>Parameter mailId used to initialize MailId Property 
        /// <param name="physicsMark"></param>Parameter physicsMark used to initialize PhysicsMark Property 
        /// <param name="chemistryMark"></param>Parameter chemistrtMark used to initialize ChemistryMark Property 
        /// <param name="mathsMark"></param>Parameter mathsMark used to initialize MathsMark Property 
        public StudentDetails(string name , string fatherName , Gender gender , DateTime dateOfBirth , string mailId, int physicsMark ,int chemistryMark ,int mathsMark )
        {
            s_registrationId++;
            RegistrationId = "SF" + s_registrationId;
            StudentName = name;
            FatherName = fatherName;
            StudentGender = gender;
            DOB = dateOfBirth ; 
            MailId = mailId;
            PhysicsMark = physicsMark;
            ChemistryMark = chemistryMark;
            MathsMark = mathsMark;
        }

        ~StudentDetails()
        {
            System.Console.WriteLine("Done");
        }
        /// <summary>
        /// Check the eligibility creteria for the Student
        /// </summary>
        /// <param name="cutOff"></param>Eligible cutoff value is passed as the parameter for Validating
        /// <returns>returns true if cutoff is eligible for Admission else return false</returns>
        public bool CheckEligibility (double cutOff)
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