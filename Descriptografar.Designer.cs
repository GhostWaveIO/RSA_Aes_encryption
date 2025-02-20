
namespace Criptografia_RSA_e_AES {
  partial class Criptogr {
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
      this.tBox_criptografia = new System.Windows.Forms.TextBox();
      this.lb_criptografia = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.btn_teste = new System.Windows.Forms.Button();
      this.lb_resultado = new System.Windows.Forms.Label();
      this.tBox_resultado = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // tBox_criptografia
      // 
      this.tBox_criptografia.Location = new System.Drawing.Point(98, 42);
      this.tBox_criptografia.Name = "tBox_criptografia";
      this.tBox_criptografia.Size = new System.Drawing.Size(604, 23);
      this.tBox_criptografia.TabIndex = 2;
      // 
      // lb_criptografia
      // 
      this.lb_criptografia.AutoSize = true;
      this.lb_criptografia.Location = new System.Drawing.Point(98, 24);
      this.lb_criptografia.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
      this.lb_criptografia.Name = "lb_criptografia";
      this.lb_criptografia.Size = new System.Drawing.Size(70, 15);
      this.lb_criptografia.TabIndex = 4;
      this.lb_criptografia.Text = "Criptografia";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(205, 302);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(178, 49);
      this.button1.TabIndex = 8;
      this.button1.Text = "Executar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btn_teste
      // 
      this.btn_teste.Location = new System.Drawing.Point(418, 302);
      this.btn_teste.Name = "btn_teste";
      this.btn_teste.Size = new System.Drawing.Size(178, 49);
      this.btn_teste.TabIndex = 9;
      this.btn_teste.Text = "Teste";
      this.btn_teste.UseVisualStyleBackColor = true;
      this.btn_teste.Click += new System.EventHandler(this.btn_teste_Click);
      // 
      // lb_resultado
      // 
      this.lb_resultado.AutoSize = true;
      this.lb_resultado.Location = new System.Drawing.Point(98, 83);
      this.lb_resultado.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
      this.lb_resultado.Name = "lb_resultado";
      this.lb_resultado.Size = new System.Drawing.Size(59, 15);
      this.lb_resultado.TabIndex = 19;
      this.lb_resultado.Text = "Resultado";
      // 
      // tBox_resultado
      // 
      this.tBox_resultado.Location = new System.Drawing.Point(98, 104);
      this.tBox_resultado.Multiline = true;
      this.tBox_resultado.Name = "tBox_resultado";
      this.tBox_resultado.Size = new System.Drawing.Size(604, 69);
      this.tBox_resultado.TabIndex = 18;
      // 
      // Criptogr
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lb_resultado);
      this.Controls.Add(this.tBox_resultado);
      this.Controls.Add(this.btn_teste);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lb_criptografia);
      this.Controls.Add(this.tBox_criptografia);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Criptogr";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Descriptografar";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tBox_chavePublica;
    private System.Windows.Forms.TextBox tBox_criptografia;
    private System.Windows.Forms.Label lb_criptografia;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btn_teste;
    private System.Windows.Forms.Label lb_resultado;
    private System.Windows.Forms.TextBox tBox_resultado;
  }
}