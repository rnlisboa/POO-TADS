using System;
using System.Globalization;
using System.Threading;

class Program {
    private static Agenda agenda = new Agenda();
    private static void Main(string[] args){
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-br");
        int op = Menu();

        while (op != 0){
            switch(op){
                case 1: Inserir(); break;
                case 2: Excluir(); break;
                case 3: Listar(); break;
                case 4: Pesquisar(); break;
            }
        }
    }

    public static int Menu(){
        Console.Write("0-Fim, 1-Inserir, 2-Excluir, 3-Listar, 4-Pesquisar\n\n");
        return int.Parse(Console.ReadLine());
    }

    public static void Inserir(){
         Console.WriteLine("Inserir novo compromisso");
         Console.WriteLine("#----------------------#");
         Console.Write("Informe o assunto: ");
         string assunto = Console.ReadLine();
         Console.Write("Informe o local: ");
         string local = Console.ReadLine();
         Console.Write("Informe a data: ");
         string local = Console.ReadLine();
         DateTime data = DateTime.Parse(Console.ReadLine());
         Compromisso c = new Compromisso { Assunto = assunto, Local = local, Data = data}
    }
}

class Compromisso {
    public string Assunto { get; set; }
    public string Local { get; set; }
    public DateTime Data { get; set; }
    public override ToString(){
        $"{Assunto} - {Local} - {Data:dd/MM/yyy hh:mm}";
    } 
}

class Agenda {
    private Compromisso[] comps = new Compromisso[2];
    private int k;
    public int Qtd { get { return k; } }
    
    public void Inserir(Compromisso c){
        //Duplica o tamanho do vetor quando estiver preenchido
        if(k == comps.Length)
            Array.Resize(ref comps,  2 * comps.Length);
        comps[k] = c;
        k++
    }
    public Compromisso[] Listar(){
        Compromisso[] aux = new Compromisso[k];
        Array.Copy(comps, aux, k)
        return aux;
    }
}