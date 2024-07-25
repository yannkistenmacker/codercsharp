using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar },
                {"Conversoes - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },
                // Estruturas de controle
                {"Estrutura if - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura if/else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura if/elseif - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}