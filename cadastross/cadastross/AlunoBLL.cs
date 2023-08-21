using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastross
{
    internal class AlunoBLL
    {
        public static void validaDados()
        {
            Erro.setErro(false);
            if (Aluno.getNome().Length == 0)
            {
                Erro.setErro("O campo NOME é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(Aluno.getRa());
                }
                catch
                {
                    Erro.setErro("O RA deve ser numérico!");
                    return;
                }

                if (Aluno.getTelefone().Length != 14)
                {
                    Erro.setErro("O campo Telefone é de preenchimento obrigatório!");
                    return;
                }
                if (Aluno.getSexo().Length == 0)
                {
                    Erro.setErro("O campo Sexo é de preenchimento obrigatório!");
                    return;
                }
            }
        }
    }
}
    


    

