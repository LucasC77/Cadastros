using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastross
{
    internal class Produtos
    {
        private static String codigo;
        private static String descricao;
        private static String fornecedor;
        private static String qtdestoque;
        private static String valorunitario;

        public static void setCodigo(String _codigo) { codigo = _codigo; }
        public static String getCodigo() { return codigo; }

        public static void setDescricao(String _descricao) { descricao = _descricao; }
        public static String getDescricao() { return descricao; }

        public static void setFornecedor(String _fornecedor) { fornecedor = _fornecedor; }
        public static String getFornecedor() { return fornecedor; }

        public static void setQtdestoque(String _qtdestoque) { qtdestoque = _qtdestoque; }
        public static String getQtdestoque() { return qtdestoque; }
        public static void setValorunitario(String _valorunitario) { valorunitario = _valorunitario; }
        public static String getValorunitario() { return valorunitario; }
    }
}
