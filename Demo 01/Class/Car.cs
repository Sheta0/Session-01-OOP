using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01._02_Class
{
    internal class Car
    {
        #region Attributes

        private int id;
        private string? model;
        private double speed;

        #endregion Attributes

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        #endregion Properties



        #region Constructors
        // If no User-Defined Constructor exists, CLR will always generate Empty Parameterles Constructor (Do Nothing)
        //public Car()
        //{

        //}
        // If you defined a constructor, Compiler will no longer generate the Empty Parameterles Constructor


        public Car(int _id, string? _model, double _speed) : this(_id, _model) // Constructor Chaining
        {
            speed = _speed;
        }

        public Car(int _id,string? _model) : this(_id) // Constructor Chaining
        {
            model = _model;
        }

        public Car(int _id)
        {
            id = _id;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Id : {id}\nModel : {model}\nSpeed : {speed}";
        } 

        #endregion
    }
}