using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_04
{
    partial class Form2 : Form
    {
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label labelMensagem;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnEnviar;
        private Button btnLimpar;
        private Label labelErroNota1;
        private Label labelErroNota2;
        private Label LabelErroNome;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.labelErroNota1 = new System.Windows.Forms.Label();
            this.labelErroNota2 = new System.Windows.Forms.Label();
            this.LabelErroNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Nome do aluno:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " Nota do 1º semestre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota do 2º semestre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(72, 227);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(152, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(231, 227);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.ForeColor = System.Drawing.Color.Red;
            this.labelMensagem.Location = new System.Drawing.Point(72, 200);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(0, 13);
            this.labelMensagem.TabIndex = 8;
            // 
            // labelErroNota1
            // 
            this.labelErroNota1.AutoSize = true;
            this.labelErroNota1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelErroNota1.Location = new System.Drawing.Point(72, 195);
            this.labelErroNota1.Name = "labelErroNota1";
            this.labelErroNota1.Size = new System.Drawing.Size(101, 13);
            this.labelErroNota1.TabIndex = 9;
            this.labelErroNota1.Text = "A Nota é obrigatória";
            this.labelErroNota1.Visible = false;
            this.labelErroNota1.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelErroNota2
            // 
            this.labelErroNota2.AutoSize = true;
            this.labelErroNota2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelErroNota2.Location = new System.Drawing.Point(226, 195);
            this.labelErroNota2.Name = "labelErroNota2";
            this.labelErroNota2.Size = new System.Drawing.Size(101, 13);
            this.labelErroNota2.TabIndex = 10;
            this.labelErroNota2.Text = "A Nota é obrigatória";
            this.labelErroNota2.Visible = false;
            this.labelErroNota2.Click += new System.EventHandler(this.LabelErroNota2_Click);
            // 
            // LabelErroNome
            // 
            this.LabelErroNome.AutoSize = true;
            this.LabelErroNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelErroNome.Location = new System.Drawing.Point(75, 91);
            this.LabelErroNome.Name = "LabelErroNome";
            this.LabelErroNome.Size = new System.Drawing.Size(107, 13);
            this.LabelErroNome.TabIndex = 11;
            this.LabelErroNome.Text = "O Nome é obrigatório";
            this.LabelErroNome.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status do aluno: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(168, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nota não enviada";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelErroNome);
            this.Controls.Add(this.labelErroNota2);
            this.Controls.Add(this.labelErroNota1);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            labelMensagem.Text = "";
            label5.Text = "Nota não enviada";
            label5.ForeColor = Color.Gray;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string nota1Text = textBox2.Text.Trim();
            string nota2Text = textBox3.Text.Trim();

            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrEmpty(nome))
            {
                LabelErroNome.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(nota1Text))
            {
                labelErroNota1.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(nota2Text))
            {
                labelErroNota2.Visible = true;
                return;
            }
            labelMensagem.Text = "";

            // Verifica se as notas são números válidos
            if (!double.TryParse(nota1Text, out double nota1) || !double.TryParse(nota2Text, out double nota2))
            {
                MessageBox.Show("As notas devem ser números válidos.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcula a média do aluno
            double media = (nota1 + nota2) / 2;

            // Define o resultado com base na média
            if (media >= 6.5)
            {
                label5.Text = "Aprovado";
                label5.ForeColor = Color.Green;
                //MessageBox.Show("Aprovado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label5.Text = "Reprovado";
                label5.ForeColor = Color.Red;
                MessageBox.Show("Reprovado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Label label4;
        private Label label5;
    }
}
