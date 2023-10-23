using System;
using System.Collections.Generic;

namespace Calc
{
    public class Calculadora
    {
        private List<string> lstHistoricoCalculos;

        public Calculadora()
        {
            lstHistoricoCalculos = new List<string>();
        }

        // Método privado para adicionar uma entrada ao histórico
        private void RegistrarHistorico(string operacao, int a, int b, int resultado, DateTime data)
        {
            lstHistoricoCalculos.Insert(0, $"{a} {operacao} {b} = {resultado} - Data: {data}");
        }

        // Método estático para somar dois números
        public int Somar(int a, int b)
        {
            int resultado = a + b;
            RegistrarHistorico("+", a, b, resultado, DateTime.Now);
            return resultado;
        }

        // Método estático para subtrair dois números
        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            RegistrarHistorico("-", a, b, resultado, DateTime.Now);
            return resultado;
        }

        // Método estático para multiplicar dois números
        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            RegistrarHistorico("*", a, b, resultado, DateTime.Now);
            return resultado;
        }

        // Método estático para dividir dois números
        public int Dividir(int a, int b)
        {
            //if (b == 0)
            //{
            //    throw new ArgumentException("Não é possível dividir por zero.");
            //}
            int resultado = a / b;
            RegistrarHistorico("/", a, b, resultado, DateTime.Now);
            return resultado;
        }

        // Método para obter o histórico
        public List<string> Historico()
        {
            // Limitar o histórico a 3 entradas
            if (lstHistoricoCalculos.Count > 3)
            {
                lstHistoricoCalculos.RemoveRange(3, lstHistoricoCalculos.Count - 3);
            }
            return lstHistoricoCalculos;
        }
    }
}
