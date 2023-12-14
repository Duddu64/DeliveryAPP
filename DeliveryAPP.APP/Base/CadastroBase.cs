using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace DeliveryAPP.APP.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        public CadastroBase()
        {
            InitializeComponent();
        }

        #region Eventos

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                poisonTabControl1.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente deletar?", @"IFSP Store", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Delivery APP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridViewConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        #endregion

        #region CRUD Methods
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in tabCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
            poisonTabControl1.SelectedIndex = 0;
            tabCadastro.Focus();
        }
        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                CarregaRegistro(linha);
                poisonTabControl1.SelectedIndex = 0;
                tabCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP Store", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }

        #endregion

    }
}
