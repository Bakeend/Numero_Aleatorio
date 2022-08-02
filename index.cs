using System; //Padrão do Sistema 
namespace index { //Padrão do Sistema 
    class Program { //Padrão do Sistema 
        static void Main(string[] agrs) { //Padrão do Sistema 
            Console.WriteLine("Olá, bem vindo ao jogo de adivinhe o núemro."); // Mensagem Que Vai Aparecer pro usuario
            Console.Write("Deseja ver como funciona (y/n) "); // Mensagem Que Vai Aparecer pro usuario
            char r = Convert.ToChar(Console.ReadLine()); // pegar resposta do usuario
            Console.Clear();
            if (r == 'y' || r == 'Y') { // vai analisar se usuario quer como funciona
                Console.WriteLine("Olá jogo funciona da seguinte forma, sistema irá escolher \n" + // Mensagem Que Vai Aparecer pro usuario
                "um numero aleatorio e tente adivinha-lo (obs: são números de 1 - 10) \n"); // Mensagem Que Vai Aparecer pro usuario
                Console.Write("Clica Enter para continuar...."); // Mensagem Que Vai Aparecer pro usuario
                Console.ReadLine(); // para usuario clicar enter
            }
            Random rnd = new Random(); // padrão para criar número
            int ranNum= rnd.Next(1, 10); // vai gerar número
            Console.Write("Escolhe numero..... "); // Mensagem Que Vai Aparecer pro usuario
            int nu = Convert.ToInt32(Console.ReadLine());
            if (ranNum == nu) { // Vai analisar se número é o correto
                Console.WriteLine("Você Acerto!!! Parabéns."); // Mensagem Que Vai Aparecer pro usuario
            }
            else {
                Console.WriteLine("Você Errou!! :( \n" + // Mensagem Que Vai Aparecer pro usuario
                "Número era " + ranNum); // Mensagem Que Vai Aparecer pro usuario e numero
            }
        }
    }
    
}
