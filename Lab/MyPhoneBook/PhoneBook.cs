using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MyPhoneBook
{


    internal class PhoneBook : Dictionary<string, int>
    {
        //internal class Person
        //{
        //    public int Number { get; set; }
        //    public string? Name { get; set; }
        //    public override string ToString()
        //    {
        //        return $"Name: {Name}, Number: {Number}";
        //    }
        //}



        #region Fields

        //private Person[] persons;
        //private int currentIndex = -1;
        #endregion

        #region Indexer
        public string this[int userNumber]
        {
            get
            {
                foreach (KeyValuePair<string, int> user in this)
                    if (user.Value == userNumber) return user.Key;

                return "USER NOT FUONDED";
            }
            set
            {
                if (this.TryAdd(value, userNumber)) return;
                Remove(value);
                Add(value, userNumber);
            }
        }
        #endregion

        
    }
}
