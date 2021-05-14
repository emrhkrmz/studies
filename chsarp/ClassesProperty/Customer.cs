using System;
namespace ClassesProperty
{
    public class Customer
    {
        public int Id { get; set; } //oto property
        public string _firstName; //field tanımladık
        public string FirstName
        {
            get { return "İsim : " + _firstName; }
            set { _firstName = value; }
        }
        public string _lastName;
        public string LastName
        {
            get { return "Soyisim : " + _lastName; }
            set { _lastName = value; }
        }
        public string City { get; set; } //oto property
    }
}
