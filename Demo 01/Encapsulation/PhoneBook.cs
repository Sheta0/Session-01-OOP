using System.Collections;

namespace Demo_01.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes

        private string[] names;
        private long[] numbers;
        private int size;

        #endregion Attributes

        #region Properties

        public int Size { get { return size; } } // Readonly Property

        // 3. Indexer => is a Special Property => Named always with the keyword "this" and Takes parameters
        public long this[string Name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                    for (int i = 0; i < names.Length; i++)
                        if (Name == names[i])
                        {
                            numbers[i] = value; // Update
                            break;
                        }
            }
        }

        public string this[long Number]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (Number == numbers[i])
                        {
                            return names[i];
                        }
                    }
                }
                return "Number Not Found";
            }
            set
            {
                if (names is not null && numbers is not null)
                    for (int i = 0; i < numbers.Length; i++)
                        if (Number == numbers[i])
                        {
                            names[i] = value;
                            break;
                        }
            }
        }

        #endregion Properties

        #region Constructors

        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }

        #endregion Constructors

        #region Methods

        public void AddPerson(string name, long number, uint index)
        {
            if (names is not null && numbers is not null)
            {
                if (index < size)
                {
                    names[index] = name;
                    numbers[index] = number;
                }
            }
        }

        // Getter
        public long GetNumber(string name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }

        //Setter
        public void SetNumber(string name, long newNumber)
        {
            if (names is not null && numbers is not null)
                for (int i = 0; i < names.Length; i++)
                    if (name == names[i])
                    {
                        numbers[i] = newNumber; // Update
                        break;
                    }
        }
        
        // Getter
        public string GetName(long number)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (number == numbers[i])
                    {
                        return names[i];
                    }
                }
            }
            return "Number Not Found";
        }

        //Setter
        public void SetName(long number, string newName)
        {
            if (names is not null && numbers is not null)
                for (int i = 0; i < numbers.Length; i++)
                    if (number == numbers[i])
                    {
                        names[i] = newName; 
                        break;
                    }
        }

        #endregion Methods
    }
}