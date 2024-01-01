using Library_DataAccessLayer;
using System;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? PersonID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public char? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? NationalityCountryID { get; set; }
        public string PersonalImagePath { get; set; }
        public string Password { get; set; }

        public clsPerson()
        {
            _Mode = enMode.AddNew;
            PersonID = null;
            FirstName = null;
            LastName = null;
            NationalNo = null;
            Gender = null;
            BirthDate = null;
            Address = null;
            Phone = null;
            Email = null;
            NationalityCountryID = null;
            PersonalImagePath = null;
            Password = null;
        }
        private clsPerson(int? PersonID, string FirstName, string LastName, string NationalNo, char? Gender, DateTime? BirthDate, string Address, string Phone, string Email, int? NationalityCountryID, string PersonalImagePath, string Password)
        {
            _Mode = enMode.Update;
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.Gender = Gender;
            this.BirthDate = BirthDate;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.PersonalImagePath = PersonalImagePath;
            this.Password = Password;
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = null;
            string LastName = null;
            string NationalNo = null;
            char? Gender = null;
            DateTime? BirthDate = null;
            string Address = null;
            string Phone = null;
            string Email = null;
            int? NationalityCountryID = null;
            string PersonalImagePath = null;
            string Password = null;

            bool IsFound = clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref NationalNo, ref Gender, ref BirthDate, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref PersonalImagePath, ref Password);

            if (IsFound)
                return new clsPerson(PersonID, FirstName, LastName, NationalNo, Gender, BirthDate, Address, Phone, Email, NationalityCountryID, PersonalImagePath, Password);
            else
                return null;
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(FirstName, LastName, NationalNo, Gender, BirthDate, Address, Phone, Email, NationalityCountryID, PersonalImagePath, Password);
            return PersonID.HasValue;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePersonInfo(PersonID, FirstName, LastName, NationalNo, Gender, BirthDate, Address, Phone, Email, NationalityCountryID, PersonalImagePath, Password);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePerson();

            }
            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

    }
}