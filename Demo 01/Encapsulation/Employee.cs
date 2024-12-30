using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.Encapsulation
{
    internal struct Employee
    {

        #region Attributes
        private int id;
        private string name;
        private double salary;
        //Address
        #endregion

        #region Properties
        // 1.2 Applying Encapsulation : using new approach [Property] => Recommended : Easy to use like dealing with an attribute
        // 1.2.1 Full Property

        // Id
        public int Id
        {
            get
            {
                return id;
            }
        }

        // Name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.Length >= 8 || value.Length <= 3 ? value : ""; 
            }
        }

        // Salary
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value < 5000 ? 0 : value; 
            }
        }

        // 1.2.2 Automatic property
        // Compiler Will Generate Backing field "Hidden private Attribute"
        //int backingfield_age;
        public string Address { get; set; }
        #endregion

        #region Code Snippets
        //// propfull => code snippet for the full property
        //private string address;

        //public string Address
        //{
        //    get { return address; }
        //    set { address = value; }
        //}

        //// prop => code snippet for automatic property
        //public string? Address { get; set; } 
        #endregion

        #region Constructor
        public Employee(int _id, string _name, double _salary)
        {
            //SetId(_id);
            SetName(_name);
            SetSalary(_salary);

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {id}\nName : {name}\nSalary : {salary:c}\n";
        }

        // 1.1 Applying Encapsulation : Using Old Approach [getter setter methods]

        // Setter 
        //public void SetId(int _id)
        //{
        //    id = _id;
        //}
        
        // Getter 
        public int GetId()
        {
            return id;
        }
        
        // Setter 
        public void SetName(string _name)
        {
            if(_name.Length >= 8 || _name.Length <= 3)
                name = _name;
        }
        
        // Getter 
        public string GetName()
        {
            return name;
        }
        
        // Setter 
        public void SetSalary(double _salary)
        {
            if(_salary >= 5000)
                salary = _salary;
        }
        
        // Getter 
        public double GetSalary()
        {
            return salary;
        }



        #endregion
    }
}
