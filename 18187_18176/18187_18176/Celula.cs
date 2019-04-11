/*
 *   Arthur Kenji Balduino   18176.
 *   Murilo Sanches de Paula 18187.    
 */ 
public class Celula
{
    /* Atributos que apontam para uma proxima celula da this, a sua direita ou abaixo. */
    Celula abaixo, direita; 

    /* Atributos o qual indicam, a posicao da celula, linha e coluna. */
    int linha, coluna;

    /* Atributo que guarda o valor da celula. */
    double valor;

    /*  Construtor.
     *  Recebe como parametro o valor dos atributos da classe.
     */
    public Celula(double valor, int linha, int coluna, Celula abaixo, Celula direita)
    {
        this.abaixo = abaixo;
        this.direita = direita;
        this.linha = linha;
        this.coluna = coluna;
        this.valor = valor;
    }

    /* Getters e Setters dos atributos */

    public Celula Abaixo
    {
        get => abaixo;
        set
        {
            if(value != null)
                abaixo = value;
        }
    }

    public Celula Direita
    {
        get => direita;
        set
        {
            if (value != null)
                direita = value;
        }
    }

    public int Linha
    {
        get => linha;
        set
        {
            if (value < 0)
                linha = value;
        }
    }

    public int Coluna
    {
        get => coluna;
        set
        {
            if (value < 0)
                coluna = value;
        }
    }

    public double Valor
    {
        get => valor;
        set => valor = value;
    }
}

