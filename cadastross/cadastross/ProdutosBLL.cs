using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastross
{
    internal class ProdutosBLL
    {
        public static void validaDados()
        {
            Erro.setErro(false);
            if (Produtos.getCodigo().Length == 0)
            {
                Erro.setErro("O campo codigo é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(Produtos.getCodigo());
                }
                catch
                {
                    Erro.setErro("O campo Codigo deve ser numérico!");
                    return;
                }

                if (Produtos.getQtdestoque().Length == 0)
                {
                    Erro.setErro("O campo Quantidade de Estoque é de preenchimento obrigatório!");
                    return;
                }

                else
                {
                    try
                    {
                        float.Parse(Produtos.getQtdestoque());
                    }
                    catch
                    {
                        Erro.setErro("O campo Quantidade de estoque deve ser numérico!");
                        return;
                    }


                    if (Produtos.getValorunitario().Length == 0)
                    {
                        Erro.setErro("O campo valor unitario é de preenchimento obrigatório!");
                        return;
                    }

                    else
                    {
                        try
                        {
                            float.Parse(Produtos.getValorunitario());
                        }
                        catch
                        {
                            Erro.setErro("O campo Valor unitario de estoque deve ser numérico!");
                            return;
                        }


                        if (Produtos.getDescricao().Length == 0)
                        {
                            Erro.setErro("O campo Descriçao é de preenchimento obrigatório!");
                            return;
                        }

                        if (Produtos.getFornecedor().Length == 0)
                        {
                            Erro.setErro("O campo Fornecedor é de preenchimento obrigatório!");
                            return;
                        }
                    }
                }
            }
        }
    }
}
