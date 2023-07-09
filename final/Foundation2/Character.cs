using System;

namespace Foundation2
{
    public class Character{
        
        private string name;
        private int age;
        private string gender;
        private string fightingStyle;
    
    public Character(string name, int age, string gender, string fightingStyle){
            
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.fightingStyle = fightingStyle;
        }

        public string GetName(){

            return name;
        }
        public int GetAge(){

            return age;
        }
        public string GetGender(){

            return gender;
        }
        public string GetFightingStyle()
        {
            
            return fightingStyle;
        }
    }
}