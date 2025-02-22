namespace Aula24
{
    public class Person
    {
        //1. Atributos
        public string Name;
        public int Age;

        //2. Métodos
        public bool IfLegalPerson(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //3. Refatorar
        public string IfLegalPersonRefactor(int age)
        {
            string result = string.Empty;

            if (age >= 18)
            {
                result = "A pessoa é maior de Idade!";
                return result;
            }
            else
            {
                result = "A pessoa é menor de Idade!";
                return result;
            }

        }

        //4. Refatorado
        public string IfLegalPersonRefactorName(int age, string name)
        {
            string result = string.Empty;

            if (age >= 18)
            {
                result = "O(a) " + name + " é maior de Idade!";
                return result;
            }
            else
            {
                result = "O(a) " + name + " é menor de Idade!";
                return result;
            }

        }
    }
}
