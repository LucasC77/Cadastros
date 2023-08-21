using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastross
{
    internal class Aluno
    {
        
        private static String nome;
        private static String ra;
        private static String datanasc;
        private static String sexo;
        private static String telefone;

        public static void setNome(String _nome) { nome = _nome; }
        public static String getNome() { return nome; }

        public static void setRa(String _ra) { ra = _ra; }
        public static String getRa() { return ra;}

        public static void setData(String _data) { datanasc = _data; }
        public string getDatanasc() { return datanasc; }

        public static void setSexo(String _sexo) { sexo = _sexo; }
        public static String getSexo() { return sexo; }
         public static void setTelefone(String _telefone) { telefone = _telefone;}
        public static String getTelefone() { return telefone;}

        
    }
}
