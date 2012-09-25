using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CineC
{
    public partial class CineC : Form
    {
        public CineC()
        {
            InitializeComponent();
        }
        // Criação do ListView
        ListViewItem novoItem = new ListViewItem();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGen.SelectedIndex = 0;
            buttonSalvar.Visible = false;
            buttonPesquisar.Visible = false;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // Validação dos campos Nome, Local e Gênero
            if (textBoxNome.Text == "" || textBoxLocal.Text == "" || comboBoxGen.SelectedIndex == 0)
                MessageBox.Show("Favor preencher todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

            {
                // Criação do novo item (primeira coluna) campo Nome do filme
                novoItem = new ListViewItem();
                novoItem.Text = textBoxNome.Text;

                // Criação do primeiro subitem (segunda coluna) campo Gênero do Filme
                ListViewItem.ListViewSubItem SubitemGenero = new ListViewItem.ListViewSubItem();
                SubitemGenero.Text = comboBoxGen.SelectedItem.ToString();

                // Criação do segundo subitem (terceira coluna) campo Local que foi Assistido
                ListViewItem.ListViewSubItem SubitemLocal = new ListViewItem.ListViewSubItem();
                SubitemLocal.Text = textBoxLocal.Text;

                // Criação do terceiro subitem (quarta coluna) campo Data
                ListViewItem.ListViewSubItem SubitemData = new ListViewItem.ListViewSubItem();
                // Adiciona somente a data conforme a formatacao
                SubitemData.Text = dateTimePickerData.Value.Date.ToString("dd/MM/yyyy");

                //Adiciona os subitens ao item 
                novoItem.SubItems.Add(SubitemGenero);
                novoItem.SubItems.Add(SubitemLocal);
                novoItem.SubItems.Add(SubitemData);

                // Adiciona o item ao ListView
                listViewFilmes.Items.Add(novoItem);
                ResetForm();
                buttonPesquisar.Visible = true;
            }
        }

        public void ResetForm()
        {
            buttonAdicionar.Enabled = true;
            buttonSalvar.Visible = false;
            textBoxNome.Text = "";
            textBoxLocal.Text = "";
            comboBoxGen.SelectedIndex = 0;
            dateTimePickerData.Value = DateTime.Now;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            // verifica se o usuário selecionou algum item da lista
            if (listViewFilmes.SelectedItems.Count != 0)
            {
                int posicao = listViewFilmes.SelectedItems.Count;

                // apaga o item selecionado
                for (int i = posicao - 1; i >= 0; i--)
                {
                    // cria uma lista onde é adicionado os itens selecionados
                    ListViewItem ItemSelecionado = listViewFilmes.SelectedItems[i];
                    listViewFilmes.Items.Remove(ItemSelecionado);
                }
            }
            else
            {
                if (listViewFilmes.Items.Count == 0)
                    MessageBox.Show("Impossivel remover!\n Lista vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Selecione primeiramente um item a ser removido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listViewFilmes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditItem();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        // Metodo para Edição dos itens
        public void EditItem()
        {
            buttonSalvar.Visible = true;
            buttonAdicionar.Enabled = false;

            // Verifica se foi adicionado algum item do ListView
            if (listViewFilmes.SelectedItems.Count != 0)
            {
                // passa o valor da primeira coluna do listView para o textboxNome
                textBoxNome.Text = listViewFilmes.SelectedItems[0].SubItems[0].Text;

                // passa o valor da segunda coluna do listView para o comboBoxGen
                comboBoxGen.Text = listViewFilmes.SelectedItems[0].SubItems[1].Text;

                // passa o valor da terceira coluna do listView para o textboxLocal
                textBoxLocal.Text = listViewFilmes.SelectedItems[0].SubItems[2].Text;

                // passa o valor da terceira coluna do listview para o dateTimePivkerData, concertendo a string em data
                dateTimePickerData.Value = DateTime.Parse(listViewFilmes.SelectedItems[0].SubItems[3].Text);
            }
              
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonAdicionar.Enabled = false;

            // validação dos campos
            if (textBoxNome.Text.Trim() == "" || textBoxLocal.Text.Trim() == "" || comboBoxGen.SelectedIndex == 0)
                MessageBox.Show("Todos os campos devem estar preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Altera dados dos itens da lista
                listViewFilmes.SelectedItems[0].SubItems[0].Text = textBoxNome.Text;
                listViewFilmes.SelectedItems[0].SubItems[1].Text = comboBoxGen.SelectedItem.ToString();
                listViewFilmes.SelectedItems[0].SubItems[2].Text = textBoxLocal.Text;
                listViewFilmes.SelectedItems[0].SubItems[3].Text = dateTimePickerData.Value.ToString("dd/MM/yyyy");

                ResetForm();

                listViewFilmes.SelectedItems[0].Selected = false;
                buttonPesquisar.Visible = true;
 
            }

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Form2 pesquisar = new Form2(listViewFilmes);
            pesquisar.ShowDialog();


        }

    }
}