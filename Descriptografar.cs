using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Criptografia_RSA_e_AES {
  public partial class Criptogr:Form {

    private static RSAParameters _privateKey;
    private static RSAParameters _publicKey;

    public Criptogr() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      if(tBox_criptografia.Text == String.Empty) {
        MessageBox.Show("Informe um texto");
        return;
      }

      Criptografia cript = new Criptografia();

      tBox_resultado.Text = cript.Decrypt(tBox_criptografia.Text);
    }


    private void btn_teste_Click(object sender, EventArgs e) {
      if(tBox_criptografia.Text == String.Empty) {
        MessageBox.Show("Informe um texto");
        return;
      }

    }
  }
}
