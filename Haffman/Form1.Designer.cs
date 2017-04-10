namespace Haffman
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.ColumnSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(12, 25);
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(328, 73);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Location = new System.Drawing.Point(12, 155);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.Size = new System.Drawing.Size(328, 113);
			this.textBoxOutput.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Входной текст";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSymbol,
            this.ColumnFrequency,
            this.ColumnCode});
			this.dataGridView.Location = new System.Drawing.Point(346, 25);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView.Size = new System.Drawing.Size(236, 243);
			this.dataGridView.TabIndex = 3;
			// 
			// ColumnSymbol
			// 
			this.ColumnSymbol.Frozen = true;
			this.ColumnSymbol.HeaderText = "Символ";
			this.ColumnSymbol.Name = "ColumnSymbol";
			this.ColumnSymbol.ReadOnly = true;
			this.ColumnSymbol.Width = 50;
			// 
			// ColumnFrequency
			// 
			this.ColumnFrequency.Frozen = true;
			this.ColumnFrequency.HeaderText = "Частота";
			this.ColumnFrequency.Name = "ColumnFrequency";
			this.ColumnFrequency.ReadOnly = true;
			this.ColumnFrequency.Width = 50;
			// 
			// ColumnCode
			// 
			this.ColumnCode.Frozen = true;
			this.ColumnCode.HeaderText = "Код";
			this.ColumnCode.Name = "ColumnCode";
			this.ColumnCode.ReadOnly = true;
			this.ColumnCode.Width = 120;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Закодированное сообщение";
			// 
			// buttonStart
			// 
			this.buttonStart.Enabled = false;
			this.buttonStart.Location = new System.Drawing.Point(201, 104);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(139, 29);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Закодировать";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 282);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.textBoxInput);
			this.Name = "FormMain";
			this.Text = "Сжатие методом Хаффмана";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymbol;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrequency;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
	}
}

