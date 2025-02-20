
namespace Criptografia_RSA_e_AES {
  partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.btn_criptografar = new System.Windows.Forms.Button();
      this.btn_descriptografar = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(68, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(661, 23);
      this.textBox1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(296, 112);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(208, 66);
      this.button1.TabIndex = 1;
      this.button1.Text = "Ação";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btn_criptografar
      // 
      this.btn_criptografar.Location = new System.Drawing.Point(133, 310);
      this.btn_criptografar.Name = "btn_criptografar";
      this.btn_criptografar.Size = new System.Drawing.Size(176, 45);
      this.btn_criptografar.TabIndex = 2;
      this.btn_criptografar.Text = "Criptografar";
      this.btn_criptografar.UseVisualStyleBackColor = true;
      this.btn_criptografar.Click += new System.EventHandler(this.btn_criptografar_Click);
      // 
      // btn_descriptografar
      // 
      this.btn_descriptografar.Location = new System.Drawing.Point(492, 310);
      this.btn_descriptografar.Name = "btn_descriptografar";
      this.btn_descriptografar.Size = new System.Drawing.Size(176, 45);
      this.btn_descriptografar.TabIndex = 3;
      this.btn_descriptografar.Text = "Descriptografar";
      this.btn_descriptografar.UseVisualStyleBackColor = true;
      this.btn_descriptografar.Click += new System.EventHandler(this.btn_descriptografar_Click);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(68, 54);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(661, 23);
      this.textBox2.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.btn_descriptografar);
      this.Controls.Add(this.btn_criptografar);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btn_criptografar;
    private System.Windows.Forms.Button btn_descriptografar;
    private System.Windows.Forms.TextBox textBox2;
  }
}

