using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    abstract class Human
    {
        string name;
        int yearOfBirth;
        Image picture;

        public string getName() {
            return this.name;
        }

        public int getBirthYear() {
            return this.yearOfBirth;
        }

        public int getAge() {
            return DateTime.Now.Year - this.yearOfBirth;
        }


        public Image getImage() {
            return this.picture;
        }



    }
}
