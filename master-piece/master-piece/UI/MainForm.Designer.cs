﻿namespace master_piece
{
    partial class MainForm
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
            this.button_process = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нечёткиеПеременныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.label_log = new System.Windows.Forms.Label();
            this.dataGridView_expressions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_intVariables = new System.Windows.Forms.DataGridView();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifierValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ifExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thenExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elseExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expressions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_intVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // button_process
            // 
            this.button_process.Location = new System.Drawing.Point(678, 614);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(123, 23);
            this.button_process.TabIndex = 2;
            this.button_process.Text = "Начать обработку";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нечёткиеПеременныеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // нечёткиеПеременныеToolStripMenuItem
            // 
            this.нечёткиеПеременныеToolStripMenuItem.Name = "нечёткиеПеременныеToolStripMenuItem";
            this.нечёткиеПеременныеToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.нечёткиеПеременныеToolStripMenuItem.Text = "Лингвистические переменные";
            this.нечёткиеПеременныеToolStripMenuItem.Click += new System.EventHandler(this.нечёткиеПеременныеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(807, 47);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(465, 591);
            this.richTextBox_log.TabIndex = 4;
            this.richTextBox_log.Text = "";
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(804, 31);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(119, 13);
            this.label_log.TabIndex = 8;
            this.label_log.Text = "Процесс выполнения:";
            // 
            // dataGridView_expressions
            // 
            this.dataGridView_expressions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_expressions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expressions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ifExpression,
            this.thenExpression,
            this.elseExpression});
            this.dataGridView_expressions.Location = new System.Drawing.Point(20, 232);
            this.dataGridView_expressions.Name = "dataGridView_expressions";
            this.dataGridView_expressions.RowHeadersVisible = false;
            this.dataGridView_expressions.Size = new System.Drawing.Size(781, 376);
            this.dataGridView_expressions.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите выражения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите переменные:";
            // 
            // dataGridView_intVariables
            // 
            this.dataGridView_intVariables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_intVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_intVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifier,
            this.identifierValue});
            this.dataGridView_intVariables.Location = new System.Drawing.Point(20, 48);
            this.dataGridView_intVariables.Name = "dataGridView_intVariables";
            this.dataGridView_intVariables.RowHeadersVisible = false;
            this.dataGridView_intVariables.Size = new System.Drawing.Size(781, 150);
            this.dataGridView_intVariables.TabIndex = 15;
            // 
            // identifier
            // 
            this.identifier.HeaderText = "Идентификатор";
            this.identifier.Name = "identifier";
            this.identifier.Width = 300;
            // 
            // identifierValue
            // 
            this.identifierValue.HeaderText = "Значение";
            this.identifierValue.Name = "identifierValue";
            this.identifierValue.Width = 300;
            // 
            // ifExpression
            // 
            this.ifExpression.HeaderText = "Если";
            this.ifExpression.Name = "ifExpression";
            this.ifExpression.Width = 400;
            // 
            // thenExpression
            // 
            this.thenExpression.HeaderText = "то";
            this.thenExpression.Name = "thenExpression";
            this.thenExpression.Width = 175;
            // 
            // elseExpression
            // 
            this.elseExpression.HeaderText = "иначе";
            this.elseExpression.Name = "elseExpression";
            this.elseExpression.Width = 175;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 650);
            this.Controls.Add(this.dataGridView_intVariables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_expressions);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.button_process);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптимизация вычисления выражений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expressions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_intVariables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нечёткиеПеременныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.DataGridView dataGridView_expressions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_intVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ifExpression;
        private System.Windows.Forms.DataGridViewTextBoxColumn thenExpression;
        private System.Windows.Forms.DataGridViewTextBoxColumn elseExpression;
    }
}

