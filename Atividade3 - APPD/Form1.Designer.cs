namespace Atividade3___APPD
{
    partial class ListaTarefas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTarefas));
            this.DataPicker = new System.Windows.Forms.DateTimePicker();
            this.DataTarefa = new System.Windows.Forms.Label();
            this.NomeTarefa = new System.Windows.Forms.Label();
            this.Tarefa = new System.Windows.Forms.TextBox();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.CxTarefa = new System.Windows.Forms.ListBox();
            this.Balao = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // DataPicker
            // 
            this.DataPicker.CustomFormat = "DD/ZZ/AA";
            this.DataPicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataPicker.Location = new System.Drawing.Point(115, 51);
            this.DataPicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DataPicker.Name = "DataPicker";
            this.DataPicker.Size = new System.Drawing.Size(543, 32);
            this.DataPicker.TabIndex = 0;
            this.Balao.SetToolTip(this.DataPicker, "Digite a data da tarefa.");
            this.DataPicker.Value = new System.DateTime(2023, 2, 27, 0, 0, 0, 0);
            this.DataPicker.ValueChanged += new System.EventHandler(this.DataPicker_ValueChanged);
            // 
            // DataTarefa
            // 
            this.DataTarefa.AutoSize = true;
            this.DataTarefa.Location = new System.Drawing.Point(28, 57);
            this.DataTarefa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DataTarefa.Name = "DataTarefa";
            this.DataTarefa.Size = new System.Drawing.Size(57, 24);
            this.DataTarefa.TabIndex = 1;
            this.DataTarefa.Text = "Data";
            // 
            // NomeTarefa
            // 
            this.NomeTarefa.AutoSize = true;
            this.NomeTarefa.Location = new System.Drawing.Point(28, 115);
            this.NomeTarefa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NomeTarefa.Name = "NomeTarefa";
            this.NomeTarefa.Size = new System.Drawing.Size(75, 24);
            this.NomeTarefa.TabIndex = 2;
            this.NomeTarefa.Text = "Tarefa";
            // 
            // Tarefa
            // 
            this.Tarefa.Location = new System.Drawing.Point(115, 111);
            this.Tarefa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Tarefa.Name = "Tarefa";
            this.Tarefa.Size = new System.Drawing.Size(543, 32);
            this.Tarefa.TabIndex = 3;
            this.Tarefa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(680, 255);
            this.BtnRemover.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(168, 86);
            this.BtnRemover.TabIndex = 4;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(680, 69);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(168, 60);
            this.BtnIncluir.TabIndex = 5;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // CxTarefa
            // 
            this.CxTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CxTarefa.FormattingEnabled = true;
            this.CxTarefa.ItemHeight = 24;
            this.CxTarefa.Location = new System.Drawing.Point(115, 170);
            this.CxTarefa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CxTarefa.Name = "CxTarefa";
            this.CxTarefa.ScrollAlwaysVisible = true;
            this.CxTarefa.Size = new System.Drawing.Size(543, 244);
            this.CxTarefa.TabIndex = 6;
            // 
            // Balao
            // 
            this.Balao.IsBalloon = true;
            this.Balao.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ListaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 471);
            this.Controls.Add(this.CxTarefa);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.Tarefa);
            this.Controls.Add(this.NomeTarefa);
            this.Controls.Add(this.DataTarefa);
            this.Controls.Add(this.DataPicker);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaTarefas";
            this.Text = "Lista de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker DataPicker;
        private Label DataTarefa;
        private Label NomeTarefa;
        private TextBox Tarefa;
        private Button BtnRemover;
        private Button BtnIncluir;
        private ListBox CxTarefa;
        private ToolTip Balao;
    }
}