using System;
using System.IO;
using System.Windows.Forms;

/* 
 *   Arthur Kenji Balduino   18176.
 *   Murilo Sanches de Paula 18187.   
 *
 */
public partial class frmMatriz : Form
{
    /* Declaração das matrizes */
    protected ListaCircular Matriz1, Matriz2; 

    public frmMatriz()
    {
        InitializeComponent();
    }
    
    /* 
     * Evento click do botão ler matriz:     
     * Lê uma determinada matriz de um arquivo texto e exibe ele em um data grid view.
     * 
     */
    private void btnLerMatriz1_Click(object sender, EventArgs e)
    {
        LerMatrizArquivo(ref Matriz1);
        if (Matriz1 != null)
        {
            Matriz1.Exibir(dgvMatriz1);
            qtdCol1.Maximum = Matriz1.QntColuna - 1;
            qtdLi1.Maximum = Matriz1.QntLinha - 1;
            setEnabled1(true);
        }
    }

   /* 
    * Evento click do botão ler matriz:     
    * Lê uma determinada matriz de um arquivo texto e exibe ele em um data grid view.
    * 
    */
    private void btnLerMatriz2_Click(object sender, EventArgs e)
    {
        LerMatrizArquivo(ref Matriz2);
        if (Matriz2 != null)
        {
            Matriz2.Exibir(dgvMatriz2);
            qtdCol2.Maximum = Matriz2.QntColuna - 1;
            qtdLi2.Maximum = Matriz2.QntLinha - 1;
            setEnabled2(true);
        }
    }

    /*
     * Metodo responsavel por deixar alguns botões enabled true
     * 
     */
    private void setEnabled1(bool valor)
    {
        qtdCol1.Enabled = valor;
        qtdLi1.Enabled = valor;
        txtValor1.Enabled = valor;
        btnExcluir1.Enabled = valor;
        btnIncluir1.Enabled = valor;
        btnSomarValor1.Enabled = valor;
        btnZerar1.Enabled = valor;
        btnProcurar1.Enabled = valor;

        if (qtdCol2.Enabled)
        {
            btnSomarMatrizes.Enabled = valor;
            btnMultiplicarMatrizes.Enabled = valor;
        }
    }

    /*
     * Metodo responsavel por deixar alguns botões enabled true
     * 
     */
    private void setEnabled2(bool valor)
    {
        qtdCol2.Enabled = valor;
        qtdLi2.Enabled = valor;
        txtValor2.Enabled = valor;
        btnExcluir2.Enabled = valor;
        btnIncluir2.Enabled = valor;
        btnSomarValor2.Enabled = valor;
        btnZerar2.Enabled = valor;
        btnProcurar1.Enabled = valor;

        if (qtdCol1.Enabled)
        {
            btnSomarMatrizes.Enabled = valor;
            btnMultiplicarMatrizes.Enabled = valor;
        }
    }

    /*
     * Evento click do botão somar valor.
     * Responsavel por somar um determinado valor em uma certa coluna na matriz
     *
     */
    private void btnSomarValor1_Click(object sender, EventArgs e)
    {
        if (txtValor1.Text != "" && double.TryParse(txtValor1.Text, out double valor))
        {
            
            Matriz1.SomarValorColuna(valor, int.Parse(qtdCol1.Value.ToString()));
            Matriz1.Exibir(dgvMatriz1);
        }
        else
            MessageBox.Show("Campo valor nulo ou incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /*
     * Evento click do botão zerar matriz.
     * Responsavel por apagar a matriz.
     * 
     */
    private void btnZerar1_Click(object sender, EventArgs e)
    {
        Matriz1.zerarMatriz();
        Matriz1.Exibir(dgvMatriz1);
        setEnabled1(false);
        txtValor1.Text = "";
        qtdCol1.Value = 0;
        qtdLi1.Value = 0;
    }

    /*
     * Evento click do botão incluir.
     * Responsavel por incluir uma nova celula na matriz.
     * 
     */
    private void btnIncluir1_Click(object sender, EventArgs e)
    {
        if (txtValor1.Text != "" && double.TryParse(txtValor1.Text, out double valor))
        {
            Matriz1.inserirCelula(valor, int.Parse(qtdLi1.Value.ToString()), int.Parse(qtdCol1.Value.ToString()));
            Matriz1.Exibir(dgvMatriz1);
        }
        else
            MessageBox.Show("Campo valor nulo ou incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /*
     * Evento click do botão excluir. 
     * Responsavel por excluir uma determinada celula.
     * 
     */
    private void btnExcluir1_Click(object sender, EventArgs e)
    {
        Matriz1.excluir(int.Parse(qtdLi1.Value.ToString()), int.Parse(qtdCol1.Value.ToString()));
        Matriz1.Exibir(dgvMatriz1);
    }

    /*
     * Evento click do botão incluir.
     * Responsavel por incluir uma nova celula na matriz.
     * 
     */
    private void btnIncluir2_Click(object sender, EventArgs e)
    {
        if (txtValor2.Text != "" && double.TryParse(txtValor2.Text, out double valor))
        {
            Matriz2.inserirCelula(valor, int.Parse(qtdLi2.Value.ToString()), int.Parse(qtdCol2.Value.ToString()));
            Matriz2.Exibir(dgvMatriz2);
        }
        else
            MessageBox.Show("Campo valor nulo ou incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

    /*
     * Evento click do botão excluir. 
     * Responsavel por excluir uma determinada celula.
     * 
     */
    private void btnExcluir2_Click(object sender, EventArgs e)
    {
        Matriz2.excluir(int.Parse(qtdLi2.Value.ToString()), int.Parse(qtdCol2.Value.ToString()));
        Matriz2.Exibir(dgvMatriz2);
        txtValor1.Text = "";
    }

    /*
     * Evento click do botão zerar matriz.
     * Responsavel por apagar a matriz.
     * 
     */
    private void btnZerar2_Click(object sender, EventArgs e)
    {
        Matriz2.zerarMatriz();
        Matriz2.Exibir(dgvMatriz2);
        setEnabled2(false);
        txtValor2.Text = "";
        qtdCol2.Value = 0;
        qtdLi2.Value = 0;
    }

    /*
     * Evento click do botão somar valor.
     * Responsavel por somar um determinado valor em uma certa coluna na matriz
     *
     */
    private void btnSomarValor2_Click(object sender, EventArgs e)
    {
        if (txtValor2.Text != "" && double.TryParse(txtValor2.Text, out double valor))
        {
            Matriz2.SomarValorColuna(double.Parse(txtValor2.Text), int.Parse(qtdCol2.Value.ToString()));
            Matriz2.Exibir(dgvMatriz2);
        }
        else
            MessageBox.Show("Campo valor nulo ou incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /*
     * Evento click do botão multiplicar matrizes
     * Responsavel por multiplicar as duas matrizes e exibir o resultado em um outro data grid view.
     * 
     */ 
    private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
    {
        if (Matriz1.QntLinha == Matriz2.QntColuna && Matriz2.QntLinha == Matriz1.QntColuna)
        {
            ListaCircular resultado = Matriz1.MultiplicarMatrizes(Matriz2);
            resultado.Exibir(dgvResultado);
        }
        else
            MessageBox.Show("Matrizes de dimensão errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /*
     * Evento click do botão somar matrizes
     * Responsavel por somar as duas matrizes e exibir o resultado em um outro data grid view.
     * 
     */
    private void btnSomarMatrizes_Click(object sender, EventArgs e)
    {
        if (Matriz1.QntLinha == Matriz2.QntLinha && Matriz2.QntColuna == Matriz1.QntColuna)
        {
            ListaCircular resultado = Matriz1.SomarMatrizes(Matriz2);
            resultado.Exibir(dgvResultado);
        }
        else
            MessageBox.Show("Matrizes de dimensão errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /*
     * Evento click do botão somar matrizes
     * Responsavel por procurar o valor de uma determinada celula pela linha e coluna.
     * 
     */
    private void btnProcurar1_Click(object sender, EventArgs e)
    {
        txtValor1.Text = Matriz1.valorDe(int.Parse(qtdLi1.Value + ""), int.Parse(qtdCol1.Value + "")) + "";
    }

    /*
    * Evento click do botão somar matrizes
    * Responsavel por procurar o valor de uma determinada celula pela linha e coluna.
    * 
    */
    private void btnProcurar2_Click(object sender, EventArgs e)
    {
        txtValor2.Text = Matriz2.valorDe(int.Parse(qtdLi2.Value + ""), int.Parse(qtdCol2.Value + "")) + "";
    }

    /*
     * Metodo responsavel por ler uma matriz de um arquivo.
     *
     */
    private void LerMatrizArquivo(ref ListaCircular lista)
    {
        string linha;

        if (dlgArquivo.ShowDialog() == DialogResult.OK)
        {
            StreamReader arq = new StreamReader(dlgArquivo.FileName);

            lista = new ListaCircular(int.Parse(arq.ReadLine()), int.Parse(arq.ReadLine()));

            while (!arq.EndOfStream)
            {
                linha = arq.ReadLine();
                string[] val = linha.Split(',');

                for (int i = 0; i < val.Length; i++)
                {
                    lista.inserirCelula(double.Parse(val[i]), int.Parse(val[++i]), int.Parse(val[++i]));
                }
            }
        }
    }
}

