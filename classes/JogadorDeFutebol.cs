using System;

namespace RepresentarJogador.classes
{
    public class JogadorDeFutebol
    {
        private string nome;
        private string posicao;
        private DateTime dataDeNascimento;
        private string nacionalidade;
        private float altura;
        private float peso;
        private int anoAtual = DateTime.Now.Year;
        private int idade;
        private int aposentar;

        public string Nome{
            set{nome = value;}
        }
        public string Posicao{
            set{posicao = value;}
        }
        public DateTime DataDeNascimento{
            set{dataDeNascimento = value;}
        }
        public string Nacionalidade{
            set{nacionalidade = value;}
        }
        public float Altura{
            set{altura = value;}
        }
        public float Peso{
            set{peso = value;}
        }

        public void ImprimirDados(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Posição: {this.posicao}");
            Console.WriteLine($"Data De Nascimento: {this.dataDeNascimento}");
            Console.WriteLine($"Nacionalidade: {this.nacionalidade}");
            Console.WriteLine($"Altura: {this.altura}");
            Console.WriteLine($"Peso: {this.peso}");
            Console.ResetColor();
        }

        public int Idade(){
            this.idade = this.anoAtual - this.dataDeNascimento.Year;
            return this.idade;
        }

        public void Aposentar(){
            switch (this.posicao)
            {
                case "defesa":
                    if (this.idade>=40)
                    {
                        Console.WriteLine($"O jogador pode se aposentar, pois tem {this.idade}");
                    }else{
                        this.aposentar = 40 - this.idade;
                        Console.WriteLine($"Falta {this.aposentar} anos para se aposentar");
                    }
                    break;
                case "meio-campo":
                    if (this.idade>=38)
                    {
                        Console.WriteLine($"O jogador pode se aposentar, pois tem {this.idade}");
                    }else{
                        this.aposentar = 38 - this.idade;
                        Console.WriteLine($"Falta {this.aposentar} anos para se aposentar");
                    }
                    break;
                case "atacante":
                    if (this.idade>=35)
                    {
                        Console.WriteLine($"O jogador pode se aposentar, pois tem {this.idade}");
                    }else{
                        this.aposentar = 35 - this.idade;
                        Console.WriteLine($"Falta {this.aposentar} anos para se aposentar");
                    }
                    break;
                default:
                    Console.WriteLine("Você informou uma posição inválida");
                    break;
            }
            
        }
    }
}