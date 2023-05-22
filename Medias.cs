using System;

class Program{
    public static void Main(string[] args){
        DisciplinaAnual dA = new DisciplinaAnual('João', 30, 40, 100, 70)
        Console.WriteLine(dA.GetNome())
    }
}

interface IDisciplina {
    string GetNome();
    int CalcMediaParcial();
    int CalcMediaFinal();
}

class DisciplinaAnual : IDisciplina{
    private string nome;
    private int nota1, nota2, nota3, nota4, notaFinal;

    public DisciplinaAnual(string n, int n1, int n2, int n3, int n4, int nF){
        this.nome = n;
        this.nota1 = n1;
        this.nota2 = n2;
        this.nota3 = n3;
        this.nota4 = n4;
        this.notaFinal = nF;
    }

    public string GetNome(){
        return this.nome;
    }
    
    public int CalcMediaParcial(){
        return (this.nota1 * 2 + this.nota2 * 2 + this.nota3 * 3 + this.nota4 * 4) / 10;
    }

    public int CalcMediaFinal(){
        return (this.CalcMediaParcial + this.notaFinal) / 2;
    }
}

class DisciplinaSemestral : IDisciplina {
    private string nome;
    private int nota1, nota2, notaFinal;

    public DisciplinaSemestral(string n, int n1,  int n2,  int nF){
        this.nome = n;
        this.nota1 = n1;
        this.nota2 = n2;
        this.notaFinal = nF;
    }

    public string GetNome(){
        return this.nome;
    }

    public int CalcMediaParcial(){
        return (this.nota1 * 2 + this.nota2 * 3) / 5;
    }

    public int CalcMediaFinal(){
        return (this.CalcMediaParcial + this.notaFinal) / 2;
    }
}