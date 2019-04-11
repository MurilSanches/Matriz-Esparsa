using System.Windows.Forms;

/* 
 *   Arthur Kenji Balduino   18176.
 *   Murilo Sanches de Paula 18187.   
 *
 *   Classe Lista Cirucular é uma classe com objetivo de fazer uma matriz
 *   através de varias celulas.
 *   Com metódos para incluir, excluir, buscar, alterar valores de uma celula.
 *   
 */
public class ListaCircular
{
    /* Atributos que apontam para determinadas celulas, para acessa-las. */
    private Celula cabeca, atualLinha, atualColuna;

    /* Atributos que guardam a quantidade de linhas e colunas da matriz. */
    private int qntLinha, qntColuna;

    /* Atributo que guarda a quantidade de celulas na matriz. */
    private int quantidade;

    /* Getters e Setters. */
    public int QntLinha { get => qntLinha; }
    public int QntColuna { get => qntColuna; }

    /* Construtor.
     * Recebe como parametro a quantidade de linhas e colunas.
     * 
     */
    public ListaCircular(int qntLi, int qntCol)
    {
        cabeca = new Celula(default(double), -1, -1, null, null);
        quantidade = 0;
        qntLinha   = qntLi;
        qntColuna  = qntCol;
        inserirNoCabeca();
    }

    /*
     * Metodo responsavel por multiplicar a matriz this com outra matriz passada como parametro.
     *      
     */
    public ListaCircular MultiplicarMatrizes(ListaCircular lista2)
    {
        ListaCircular resultado = new ListaCircular(qntLinha, lista2.QntColuna);
        for (int linha = 0; linha < qntLinha; linha++)
            for (int coluna = 0; coluna < lista2.qntColuna; coluna++)
            {
                double valor = 0;
                for (int c = 0; c < qntColuna; c++)
                    valor += valorDe(linha, c) * lista2.valorDe(c, coluna);
                if (valor != 0)
                    resultado.inserirCelula(valor, linha, coluna);
            }
                      
        return resultado;

    }
    
   /*
    * Metodo responsavel por somar a matriz this com outra matriz passada como parametro.
    *      
    */
    public ListaCircular SomarMatrizes(ListaCircular lista2)
    {      
        ListaCircular resultado = new ListaCircular(qntLinha, qntColuna);
        for (int linha = 0; linha < qntLinha; linha++)
            for (int coluna = 0; coluna < qntColuna; coluna++)
                if (valorDe(linha, coluna) + lista2.valorDe(linha, coluna) != 0)
                    resultado.inserirCelula(valorDe(linha, coluna) + lista2.valorDe(linha, coluna), linha, coluna);
        return resultado;
    }

    /*
     * Metodo que retorna true caso a lista estiver vazio, e false caso tiver alguma coisa.
     */
    public bool estaVazio()
    {
        if (this.quantidade == 0)
            return true;
        return false;
    }

    /*
     * Metodo usado no construtor da lista circular, responsavel por criar as celulas fora da matriz.
     * 
     */
    private void inserirNoCabeca()
    {
        Celula atual = cabeca;
        for (var i = 0; i < qntLinha; i++)
        {
            var cel = new Celula(0, i, -1, null, null);

            atual.Abaixo = cel;
            atual = atual.Abaixo;
            atual.Direita = atual;
        }
        atual.Abaixo = cabeca;

        atual = cabeca;
        for (var i = 0; i < qntColuna; i++)
        {
            var cel = new Celula(0, -1, i, null, null);

            atual.Direita = cel;
            atual = atual.Direita;
            atual.Abaixo = atual;
        }
        atual.Direita = cabeca;
    }
    
    /*
     * Metodo private que adiciona uma nova celula na matriz.
     * 
     */
    private void inserirCelula(Celula cel)
    {
        if(existe(cel.Linha, cel.Coluna))
            atualColuna.Abaixo.Valor = cel.Valor;
        else
        {
            cel.Abaixo = atualColuna.Abaixo;
            atualColuna.Abaixo = cel;

            cel.Direita = atualLinha.Direita;
            atualLinha.Direita = cel;

            quantidade++;
        }
    }

    /*
     * Metodo que exclui uma celula na matriz
     * 
     */
    public bool excluir(int li, int col)
    {
        if (li > 0 || col > 0 || li < qntLinha - 1 || col < qntColuna - 1)
        {
            if (existe(li, col))
            {
                Celula cel = atualLinha.Direita;

                atualColuna.Abaixo = cel.Abaixo;
                atualLinha.Direita = cel.Direita;
                quantidade--;

                return true;
            }
            return false;
        }
        return false;
    }

    /*
     * Metodo que soma um determinado valor em um certa coluna, ambos passados por parametros.
     * 
     */
    public void SomarValorColuna(double val, int coluna)
    {
        if(val >= 0 && coluna >= 0)       
            for (int i = 0; i < qntLinha; i++)
            {
                if (valorDe(i, coluna) == 0)
                    inserirCelula(val, i, coluna);
                else
                {
                    Celula cel = atualLinha.Direita;
                    if (cel.Valor + val == 0)
                        excluir(i, coluna);
                    else
                        inserirCelula(val + cel.Valor, i, coluna);
                }
            }
    }

    /*
     * Retorna o valor de uma determinada linha e coluna, caso ele exista.
     *
     */
    public double valorDe(int li, int col)
    {
        if (li > 0 || col > 0 || li < qntLinha - 1 || col < qntColuna - 1)
        {
            if (existe(li, col))
                return atualColuna.Abaixo.Valor;
            else
                return 0;
        }
        return 0;
    }

    /*
     * Exibe uma matriz em um data grid view passado como parametro.
     *
     */
    public void Exibir(DataGridView dgv)
    {
        if (dgv != null)
        {
            Celula p = cabeca;
            dgv.RowCount = qntLinha;
            dgv.ColumnCount = qntColuna;

            for (int i = 0; i < qntLinha; i++)
                for (int x = 0; x < qntColuna; x++)
                    dgv.Rows[i].Cells[x].Value = valorDe(i, x);
        }
    }

    /*
     * Metodo que zera a matriz.
     * 
     */
    public void zerarMatriz()
    {
        cabeca = atualLinha = atualColuna = null;
        quantidade = 0;
        qntLinha = 0;
        qntColuna = 0;
    }

    /*
     *  Metodo que retorna true ou false dependendo se a celula existe ou não.
     *  
     */ 
    public bool existe(int li, int col)
    {
        if (li > 0 || col > 0 || li < qntLinha - 1 || col < qntColuna - 1)
        {
            atualLinha = atualColuna = cabeca;

            for (; atualLinha.Linha < li && atualLinha.Abaixo != atualLinha; atualLinha = atualLinha.Abaixo)
            { }

            for (; atualLinha.Direita.Coluna < col && atualLinha.Direita != atualLinha && atualLinha.Direita.Coluna != -1; atualLinha = atualLinha.Direita)
            { }

            for (; atualColuna.Coluna < col && atualColuna.Direita != atualColuna; atualColuna = atualColuna.Direita)
            { }

            for (; atualColuna.Abaixo.Linha < li && atualColuna.Abaixo != atualColuna && atualColuna.Abaixo.Linha != -1; atualColuna = atualColuna.Abaixo)
            { }

            Celula procurada = atualLinha.Direita;

            if (procurada.Coluna != col || procurada.Linha != li)
                return false;

            return true;
        }
        else
            return false;
    }

    /*
     * Metodo que insere uma nova celula na matriz.     
     * 
     */
    public void inserirCelula(double valor, int linha,int coluna)
    {
        if (linha > 0 || coluna > 0 || linha < qntLinha - 1 || coluna < qntColuna - 1)
        { 
            var cel = new Celula(valor, linha, coluna, null, null);
            inserirCelula(cel);
        }
    }
}
