
namespace Criptografia_RSA_e_AES {
  partial class Criptografar2 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btn_teste = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.lb_resultado = new System.Windows.Forms.Label();
      this.lb_texto = new System.Windows.Forms.Label();
      this.tBox_resultado = new System.Windows.Forms.TextBox();
      this.tBox_texto = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btn_teste
      // 
      this.btn_teste.Location = new System.Drawing.Point(406, 323);
      this.btn_teste.Name = "btn_teste";
      this.btn_teste.Size = new System.Drawing.Size(178, 49);
      this.btn_teste.TabIndex = 19;
      this.btn_teste.Text = "Teste";
      this.btn_teste.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(193, 323);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(178, 49);
      this.button1.TabIndex = 18;
      this.button1.Text = "Executar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // lb_resultado
      // 
      this.lb_resultado.AutoSize = true;
      this.lb_resultado.Location = new System.Drawing.Point(98, 83);
      this.lb_resultado.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
      this.lb_resultado.Name = "lb_resultado";
      this.lb_resultado.Size = new System.Drawing.Size(112, 15);
      this.lb_resultado.TabIndex = 17;
      this.lb_resultado.Text = "Texto Criptografado";
      // 
      // lb_texto
      // 
      this.lb_texto.AutoSize = true;
      this.lb_texto.Location = new System.Drawing.Point(98, 24);
      this.lb_texto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
      this.lb_texto.Name = "lb_texto";
      this.lb_texto.Size = new System.Drawing.Size(35, 15);
      this.lb_texto.TabIndex = 14;
      this.lb_texto.Text = "Texto";
      // 
      // tBox_resultado
      // 
      this.tBox_resultado.Location = new System.Drawing.Point(98, 104);
      this.tBox_resultado.Multiline = true;
      this.tBox_resultado.Name = "tBox_resultado";
      this.tBox_resultado.Size = new System.Drawing.Size(604, 69);
      this.tBox_resultado.TabIndex = 13;
      // 
      // tBox_texto
      // 
      this.tBox_texto.Location = new System.Drawing.Point(98, 42);
      this.tBox_texto.Name = "tBox_texto";
      this.tBox_texto.Size = new System.Drawing.Size(604, 23);
      this.tBox_texto.TabIndex = 12;
      // 
      // Criptografar2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btn_teste);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lb_resultado);
      this.Controls.Add(this.lb_texto);
      this.Controls.Add(this.tBox_resultado);
      this.Controls.Add(this.tBox_texto);
      this.Name = "Criptografar2";
      this.Text = "Criptografar";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_teste;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lb_resultado;
    private System.Windows.Forms.Label lb_texto;
    private System.Windows.Forms.TextBox tBox_resultado;
    private System.Windows.Forms.TextBox tBox_texto;
  }
}