using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2_v2
{
    class Customer
    {
        Pizza pizza;
        #region Instance fields

        private string _firstname;
        private string _surname;
        private string _email;
        private string _phoneNumber;
        private string _streetName;
        private string _streetNumber;
        private string _city;
        private string _postalCode;
        private int _customerId;
        #endregion        


        #region Constructor

        public Customer(string firstName, string surname, string email, string phonenumber, string city, string postalCode, string streetName, string houseNumber)
        {
            _firstname = firstName;
            _surname = surname;
            _email = email;
            _phoneNumber = phonenumber;
            _streetName = streetName;
            _streetNumber = houseNumber;
            _postalCode = postalCode;
            _city = city;
            _customerId = CustomerCatalog.CustomerList.Count;
            CustomerCatalog.CustomerList.Add(this);
            


        }

        #endregion

        #region Properties

        public int CustomerId
        {
            get { return _customerId + 1; }
        }

        public string FullName
        {
            get { return $"{_firstname} { _surname}"; }
            set { FullName = value; }
        }
        public string Address
        {
            get { return $"{_streetName} {_streetNumber}"; }
        }
        public string City
        {
            get { return $"{_postalCode} {_city}"; }
        }
        public string Email
        {
            get { return $"{_email}"; }
        }
        public string PhoneNumber
        {
            get { return $"{_phoneNumber}"; }
        }
        public string CustomerInfo
        {
            get { return $"Customer Id: {CustomerId}\n{FullName}\n{Address}\n{City}\n{Email}\n{PhoneNumber}"; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{CustomerInfo}";
        }

        #endregion

    }
}
