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
    public partial class Form2 : Form
    {
        ListView Lista;

        public Form2(ListView ListaPesq)
        {
            Lista = ListaPesq; // Recebe a lista que contém os itens do Form1 e passa p/ uma nova lista
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Verificação dos campos para filtrar a partir do checkbox selecionado
            if (checkBoxNome.Checked == true)
                textBoxNome.Enabled = true;
            else
            {
                textBoxNome.Enabled = false;
                textBoxNome.Text = "";
            }

            if (checkBoxGen.Checked == true)
                comboBoxGen.Enabled = true;
            else
            {
                comboBoxGen.Enabled = false;
                comboBoxGen.SelectedIndex = 0;
            }

            if (checkBoxLocal.Checked == true)
                textBoxLocal.Enabled = true;
            else
            {
                textBoxLocal.Enabled = false;
                textBoxLocal.Text = "";
            }

            if (checkBoxData.Checked == true)
            {
                dateTimePickerData1.Enabled = true;
                dateTimePickerData2.Enabled = true;
            }
            else
            {
                dateTimePickerData1.Enabled = false; dateTimePickerData1.Value = DateTime.Now;
                dateTimePickerData2.Enabled = false; dateTimePickerData2.Value = DateTime.Now;
            }
        }

        public void ResetForm()
        {
            textBoxNome.Enabled = false;
            textBoxNome.Text = "";

            textBoxLocal.Enabled = false;
            textBoxLocal.Text = "";

            comboBoxGen.Enabled = false;
            comboBoxGen.SelectedIndex = 0;

            dateTimePickerData1.Enabled = false;
            dateTimePickerData2.Enabled = false;
            dateTimePickerData1.Value = DateTime.Now;
            dateTimePickerData2.Value = DateTime.Now;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            int erro = 0;
            List<string> OpcaoPesquisa = new List<string>();

            // Validação dos campos para pesquisa
            if (checkBoxNome.Checked == true)
            {
                if (textBoxNome.Text.Trim() != "")
                {
                    // Adiciona na Lista a opção Nome
                    OpcaoPesquisa.Add("Nome");
                }
                else
                    erro++;
            }

            if (checkBoxLocal.Checked == true)
            {
                if (textBoxLocal.Text.Trim() != "")
                {
                    // Adiciona na Lista a opção Local
                    OpcaoPesquisa.Add("Local");
                }
                else
                    erro++;
            }

            if (checkBoxGen.Checked == true)
            {
                if (comboBoxGen.SelectedIndex > 0)
                {
                    // Adiciona na Lista a opção Genero
                    OpcaoPesquisa.Add("Genero");
                }
                else
                    erro++;
            }

            if (checkBoxData.Checked == true)
            {
                // Adiciona na Lista a opção Nome
                OpcaoPesquisa.Add("Data");
            }

            // Mostra um mesagem de erro, caso tenha algum
            if (erro > 0)
                MessageBox.Show("Preencha o(s) campo(s) previamente selecionado(s).");


            // *** Faz a Pesquisa com 1 Campo *** //
            if (OpcaoPesquisa.Count == 1)
            {
                DateTime dataInicio = dateTimePickerData1.Value;
                DateTime dataFim = dateTimePickerData2.Value;

                // Limpa a lista, para uma nova pesquisa
                listViewFilmesPesq.Items.Clear();

                if (OpcaoPesquisa[0] == "Nome")
                {
                    // Percorre a lista e verifica se o nome que o usuário 
                    // informou contém na lista com os filmes cadastrados
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        // Se a pesquisa obteve algum resultado, 
                        // chama o metodo para adicionar esse resultado na lista
                        if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                    }
                }
                if (OpcaoPesquisa[0] == "Genero")
                {
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        // o campo Genero na lista é o SubItem[1]
                        if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                            AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                    }
                }
                if (OpcaoPesquisa[0] == "Local")
                {
                    // o campo local na lista é o SubItem[2]
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                            AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                    }
                }
                if (OpcaoPesquisa[0] == "Data")
                {
                    // o campo data na lista é o SubItem[3]
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        // Converte a data que esta em formato string para DateTime
                        DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                        // Verifica se a data está entre os parâmetros
                        if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                            AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                    }

                }
            }

            // *** Faz a Pesquisa com 2 Campos *** //
            if (OpcaoPesquisa.Count == 2)
            {
                DateTime dataInicio = dateTimePickerData1.Value;
                DateTime dataFim = dateTimePickerData2.Value;

                // Limpa a lista, para uma nova pesquisa
                listViewFilmesPesq.Items.Clear();

                if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Genero")
                {
                    // Faz a Pesquisa com o Nome E Genero
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        // Verifica se o Nome que o usuário informou contém no listView  
                        if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                        {
                            // Verifica se o Genero que o usuário informou comtém, no resultado da pesquisa
                            // Caso tenha o Nome e o Genero (SubItems[1]), a pesquia obteve resultado e adiciona no ListView
                            if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                        }
                    }
                }

                if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local")
                {
                    // Faz a Pesquisa com o Nome E Local
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                        {
                            // Verifica se o Local que o usuário informou comtém, no resultado da pesquisa pelo Nome
                            // Caso tenha o Nome e o Local (SubItems[2]), a pesquia obteve resultado e adiciona no ListView
                            if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                        }
                    }
                }

                if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Data")
                {
                    // Faz a pesquisa com o Nome E Data
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                        {
                            // Converte a data (SubItems[3])  do resultado da pesquisa pelo Nome
                            // que esta em formato string para DateTime
                            DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                            // Verifica se a data está entre os parâmetros
                            if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                        }
                    }
                }

                if (OpcaoPesquisa[0] == "Local" && OpcaoPesquisa[1] == "Genero")
                {
                    // Faz a Pesquisa com o Local E Genero
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        // Verifica se o Local (SubItems[2]) que o usuário informou contém no ListView
                        if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                        {
                            // Verifica se o Genero que o usuário informou comtém no resultado da pesquisa pelo Local
                            // Caso tenha o Local e o Genero (SubItems[1]), a pesquia obteve resultado e adiciona no ListView
                            if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                        }
                    }
                }

                if (OpcaoPesquisa[0] == "Local" && OpcaoPesquisa[1] == "Data")
                {
                    // Faz a pesquisa com o Local E Data
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                        {
                            // Converte a data (SubItems[3])  do resultado da pesquisa pelo Local
                            // que esta em formato string para DateTime
                            DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                            // Verifica se a data está entre os parâmetros
                            if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                        }
                    }
                }

                if (OpcaoPesquisa[0] == "Genero" && OpcaoPesquisa[1] == "Data")
                {
                    // Faz a pesquisa com o Genero E Data
                    for (int i = 0; i < Lista.Items.Count; i++)
                    {
                        // Verifica se o Genero (SubItems[1]) que o usuário informou contém no listView  
                        if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                        {
                            DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);
                            if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                        }
                    }
                }
            }

            // *** Faz a Pesquisa com 3 Campos *** //
            if (OpcaoPesquisa.Count == 3)
            {
                if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local" && OpcaoPesquisa[2] == "Genero")
                {
                    // Faz a Pesquisa com o nome, local e genero

                }

                if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local" && OpcaoPesquisa[2] == "Data")
                {
                    // Faz a Pesquisa com o nome, genero e data

                }

                if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Genero" && OpcaoPesquisa[2] == "Data")
                {
                    // Faz a pesquisa com o nome E data

                }

                if (OpcaoPesquisa[0] == "Local" && OpcaoPesquisa[1] == "Genero" && OpcaoPesquisa[2] == "Data")
                {
                    // Faz a pesquisa com o nome E data

                }

            }

            // *** Faz a Pesquisa com 4 Campos *** //
            if (OpcaoPesquisa.Count == 3)
            {
                if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local" && OpcaoPesquisa[2] == "Genero" && OpcaoPesquisa[3] == "Data")
                {
                    // Faz a Pesquisa com o nome, local, genero

                }
            }
        }

        public void AddItem(string Nome, string Genero, string Local, string Data)
        {
            // Adiciona o item conforme o resultado da pesquisa

            ListViewItem novoItem = new ListViewItem();
            novoItem.Text = Nome;

            ListViewItem.ListViewSubItem SubitemGenero = new ListViewItem.ListViewSubItem();
            SubitemGenero.Text = Genero;

            ListViewItem.ListViewSubItem SubitemLocal = new ListViewItem.ListViewSubItem();
            SubitemLocal.Text = Local;

            ListViewItem.ListViewSubItem SubitemData = new ListViewItem.ListViewSubItem();
            SubitemData.Text = Data;

            novoItem.SubItems.Add(SubitemGenero);
            novoItem.SubItems.Add(SubitemLocal);
            novoItem.SubItems.Add(SubitemData);
            listViewFilmesPesq.Items.Add(novoItem);

        }
    }
}
