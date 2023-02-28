namespace Atividade3___APPD
{
    public partial class ListaTarefas : Form
    {
        public ListaTarefas()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if ( Tarefa.Text == "")
            {
                MessageBox.Show("Digite uma Tarefa !!!");
                Tarefa.Text = " ";
            }else
            {
                CxTarefa.Items.Add($"{DataPicker.Value:d} - {Tarefa.Text}");
                Tarefa.Text = " ";
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if(this.CxTarefa.SelectedItem == null)
            {
                MessageBox.Show("Por Favor, selecione uma tarefa !!!");
            }
            else
            {
                CxTarefa.Items.Remove(this.CxTarefa.SelectedItem);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   

        }

        private void DataPicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}