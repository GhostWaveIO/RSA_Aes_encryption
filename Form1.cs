using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;

namespace Criptografia_RSA_e_AES {
  public partial class Form1:Form {

    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      string texto = textBox1.Text;
      string novoTexto = String.Empty;
      foreach(char c in textBox1.Text) {
        novoTexto += char.ConvertFromUtf32((short)c+6);
      }

      textBox2.Text = novoTexto;

    }

    private void btn_criptografar_Click(object sender, EventArgs e) {
      Criptografar2 criptografar = new Criptografar2();
      criptografar.Show();
    }

    private void btn_descriptografar_Click(object sender, EventArgs e) {
      Criptogr descriptografar = new Criptogr();
      descriptografar.Show();
    }
  }
}
