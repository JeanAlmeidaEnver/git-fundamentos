﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_01_Realizando_Filtros 
{
    class Program
    {
        private static List<Despesa> despesas = new List<Despesa>
        {
            new Despesa { Descricao = "Internet", Valor = 100, Vencimento = new DateTime(2021,10,1)},
            new Despesa { Descricao = "Celular", Valor = 80, Vencimento = new DateTime(2021,10,20)},
            new Despesa { Descricao = "Aluguel", Valor = 1200, Vencimento = new DateTime(2021,10,18)},
            new Despesa { Descricao = "Contabilidade", Valor = 400, Vencimento = new DateTime(2021,10,20)},

        };

        static void Main(string[] args)
        {
            var despesasVencidas =  from d in despesas
                                    where d.Valor < 500 
                                    orderby d.Vencimento descending, d.Valor descending
                                    select d;
            
            foreach ( var d in despesasVencidas)
            {
                Console.WriteLine(d);
            }
        }
    }
}